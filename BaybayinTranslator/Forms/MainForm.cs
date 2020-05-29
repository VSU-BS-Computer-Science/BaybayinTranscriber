using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using BaybayinTranslator.utils;

namespace BaybayinTranslator.Forms
{
    public partial class MainForm : Form
    {
        private Graphics g;
        private Baybayin baybayin;

        private bool savingToImage;

        private bool printingImage;
        private Graphics printGraphics;

        private Color imageBackColor;
        private Color imageBoxColor;

        private bool doneDrawing;

        private Bitmap tempBmp;

        private Image img;

        private System.Drawing.Printing.PrintPageEventArgs printPageEventArgs;

        public MainForm()
        {
            InitializeComponent();

            imageBackColor = Color.LightYellow;
            imageBoxColor = Color.Red;
            doneDrawing = true;

            savingToImage = false;
            printingImage = false;
            
            this.Text = "Baybayin Translator v1";
            this.Width = Screen.PrimaryScreen.Bounds.Width;
            this.Height = Screen.PrimaryScreen.Bounds.Height;
            this.WindowState = FormWindowState.Maximized;

            panelPicture.Width = this.Width - sourceText.Width - 50;
            panelPicture.Height = this.Height - 150;
            this.panelPicture.MaximumSize = new Size(panelPicture.Size.Width, panelPicture.Size.Height);
            
            baybayin = new Baybayin();

            comboBox_size.Items.Clear();

            comboBox_Translation.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_size.DropDownStyle = ComboBoxStyle.DropDownList;

            comboBox_size.Items.Add("15 px");
            for (int i = 25; i <= 300; i+=25)
                comboBox_size.Items.Add(i + " px");
            comboBox_size.SelectedIndex = 0;


            foreach (Translation t in baybayin.translations)
                comboBox_Translation.Items.Add(t.name);
            comboBox_Translation.SelectedIndex = 0;



            g = pictureBox.CreateGraphics();



            Assembly myAssembly = Assembly.GetExecutingAssembly();
            Stream myStream = myAssembly.GetManifestResourceStream("BaybayinTranslator.images.baybayin.png");

            img = Image.FromStream(myStream);

            openFileDialog.Filter = "Text file (*.txt) | *.txt";
            saveFileDialog.Filter = "BMP file(*.bmp) | *.bmp";

            buttonBackColor.BackColor = imageBackColor;
            buttonBoxColor.BackColor = imageBoxColor;

            drawLetter(null, null);
            
        }


        public void setSize(string s)
        {
            this.label_size.Text = "Size " + s;
        }

        private void drawLetter(object sender, EventArgs e)
        {
            if (g == null || !doneDrawing)
                return;
            doneDrawing = false;
            try
            {
                int size = Convert.ToInt16(comboBox_size.SelectedItem.ToString().Replace(" px", ""));
                bool writeSyllable = checkBox_ShowLetter.Checked;
                bool drawRect = checkBox_ShowBox.Checked;


                List<string> syllables = baybayin.getValidSyllables(sourceText.Text.ToLower());

                int marginX = 10;
                int marginY = 10;
                int lastX = marginX;
                int maxX = marginX;
                int maxY = marginY;

                foreach (string s in syllables)
                {

                    Rectangle vRectTop = new Rectangle(lastX + size / 2, maxY, size / 4, size / 4);
                    Rectangle letterRect = new Rectangle(lastX, vRectTop.Y + vRectTop.Height, size, size);
                    Rectangle vRectBottom = new Rectangle(vRectTop.X, letterRect.Y + letterRect.Height, size / 4, size / 4);

                    Rectangle wholeRect = new Rectangle(letterRect.X, vRectTop.Y, letterRect.Width, vRectTop.Height + letterRect.Height + vRectBottom.Height + 20);

                    if (maxY == marginY)
                        maxY = wholeRect.Y + wholeRect.Height;

                    if (s.Equals("\n"))
                    {
                        maxY = wholeRect.Y + wholeRect.Height;
                        lastX = 0;
                        continue;
                    }
                    else
                    {
                        lastX = letterRect.X + letterRect.Width;
                        maxX = lastX > maxX ? lastX : maxX;
                    }

                }


                pictureBox.Width = maxX + 2 * marginX;
                pictureBox.Height = maxY + marginY;

                g.Dispose();

                if (printingImage)
                    g = printGraphics;
                else if (savingToImage)
                    g = Graphics.FromImage(tempBmp);
                else
                    g = pictureBox.CreateGraphics();

                int pageHeight = 0;
                int offsetY = 0;
                if (printingImage)
                {

                    float pageWidth = printPageEventArgs.PageSettings.PrintableArea.Width;
                    pageHeight = (int)printPageEventArgs.PageSettings.PrintableArea.Height;

                    int pages = pictureBox.Height / pageHeight;

                 }

                g.Clear(imageBackColor);

                lastX = marginX;
                int lastY = marginY;

                foreach (string s in syllables)
                {

                    Rectangle vRectTop = new Rectangle(lastX + size / 2, lastY, size / 4, size / 4);
                    Rectangle letterRect = new Rectangle(lastX , vRectTop.Y + vRectTop.Height, size, size);
                    Rectangle vRectBottom = new Rectangle( vRectTop.X, letterRect.Y + letterRect.Height, size / 4, size / 4);

                    Rectangle wholeRect = new Rectangle(letterRect.X, vRectTop.Y, letterRect.Width, vRectTop.Height + letterRect.Height + vRectBottom.Height + 20);

                    //if (offsetY > pageHeight && printingImage)
                    //{
                    //    offsetY = 0;
                    //    printPageEventArgs.HasMorePages = true;
                    //}
                    //else if (printingImage)
                    //{
                    //    offsetY = lastY;
                    //    printPageEventArgs.HasMorePages = false;
                    //}

                    if (s.Equals("\n"))
                    {
                        lastY = wholeRect.Y + wholeRect.Height;
                        lastX = marginX;
                        continue;
                    }
                    else
                        lastX = letterRect.X  + letterRect.Width;

                    if (s.Equals(" "))
                        continue;



                    char lastChar = s.ElementAt(s.Length - 1);
                    bool hasVowel = baybayin.isVowel(lastChar);

                    bool isNG = s.ToLower().IndexOf("ng") > -1;

                    string sFind = s.Length == 1 && hasVowel ? s : s.Substring(0, hasVowel ? s.Length - 1 : s.Length);

                    BaybayinLetter letter = baybayin.SelectedTranslation.getBaybayinLetter(sFind);

                    if (letter != null)
                    {
                        g.DrawImage(img, letterRect, letter.postion, GraphicsUnit.Pixel);

                        if (hasVowel)
                        {
                            if (lastChar == 'e' || lastChar == 'i')
                            {
                                g.DrawImage(img, vRectTop, baybayin.SelectedTranslation.getBaybayinLetter("OU").postion, GraphicsUnit.Pixel);
                            }
                            else if (lastChar == 'o' || lastChar == 'u')
                            {
                                g.DrawImage(img, vRectBottom, baybayin.SelectedTranslation.getBaybayinLetter("OU").postion, GraphicsUnit.Pixel);
                            }
                        }
                        else
                        {
                            g.DrawImage(img, vRectBottom, baybayin.SelectedTranslation.getBaybayinLetter("NO_VOWEL").postion, GraphicsUnit.Pixel);
                        }

                        if (writeSyllable)
                            g.DrawString(s, this.Font, Brushes.Black, letterRect.X + (letterRect.Width / 2) - 5, vRectBottom.Y + vRectBottom.Height + 5);


                        if (drawRect)
                            g.DrawRectangle( new Pen(imageBoxColor), wholeRect);
                    }



                } 
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message + '\n' + ex.StackTrace);
            }
            doneDrawing = true;

        }

        private void panelPicture_Scroll(object sender, ScrollEventArgs e)
        {
            drawLetter(null, null);
        }

        private void comboBox_Translation_SelectedIndexChanged(object sender, EventArgs e)
        {
            baybayin.setTranslation( baybayin.translations.ElementAt(comboBox_Translation.SelectedIndex));
            drawLetter(null, null);
        }

        private void sourceText_KeyDown(object sender, KeyEventArgs e)
        {
            drawLetter(null, null);
        }

        private void panelPicture_Paint(object sender, PaintEventArgs e)
        {

        }


        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(openFileDialog.FileName);
                string line;
                sourceText.Text = "";
                while ((line = sr.ReadLine()) != null)
                {
                    sourceText.Text += line + "\r\n";
                }


                sr.Close();
            }
        }

        private void saveImageAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                savingToImage = true;
                tempBmp = new Bitmap(pictureBox.Width, pictureBox.Height);
                g = Graphics.FromImage(tempBmp);
                drawLetter(null, null);
                //pictureBox.DrawToBitmap(b, new Rectangle(0, 0, b.Width, b.Height));

                tempBmp.Save(saveFileDialog.FileName, ImageFormat.Bmp);
                tempBmp.Dispose();

                g = pictureBox.CreateGraphics();
                savingToImage = false; MessageBox.Show(this, "Image was saved!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            (new AboutForm()).ShowDialog(this);
        }

        private void baybayinChartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new BaybayinChartForm()).ShowDialog(this);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            DialogResult r = colorDialog.ShowDialog();
            if (r == DialogResult.OK)
                if (!colorDialog.Color.Equals(Color.Black))
                {
                    imageBackColor = colorDialog.Color;
                    buttonBackColor.BackColor = imageBackColor;
                    drawLetter(null, null);
                }
                else
                    MessageBox.Show(this, "Please use color other than black.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void buttonBoxColor_Click(object sender, EventArgs e)
        {


            DialogResult r = colorDialog.ShowDialog();
            if (r == DialogResult.OK)
                if (!colorDialog.Color.Equals(imageBackColor))
                {
                    imageBoxColor = colorDialog.Color;
                    buttonBoxColor.BackColor = imageBoxColor;
                    drawLetter(null, null);
                }
                else
                    MessageBox.Show(this, "Please use color other than the back color.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDocument.Print();
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            printPageEventArgs = e;
            printingImage = true;
            printGraphics = e.Graphics;

            drawLetter(null, null);
            printingImage = false;

            
;        }

        private void printDocument_EndPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            MessageBox.Show(this, "Done Printing!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            drawLetter(null, null);
        }



    }
}
