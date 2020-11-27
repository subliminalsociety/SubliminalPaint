using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32.SafeHandles;

namespace spForm
{
    public partial class mainForm : Form
    {
        
        
        //Objects
        private Graphics graphics;
        private Pen pen;
        
        
        //Object Properties
        private Color penColor;
        private Color bgColor;
        private float penWidth;

        //Collections
        private readonly List<KnownColor> knownColors = new List<KnownColor>();
        private readonly List<Color> actualColors = new List<Color>();

        
        //Variables
        
        private int x = -1;
        private int y = -1;
        private bool isDrawing;
        
        
        
        
        
        //  Initialization & Setup
        public mainForm()
        {
            InitializeComponent();
            InitializeLocals();
            ResolveColors();
        }
        private void InitializeLocals()
        {
            bgColor = Color.White;
            penColor = Color.Black;
            penWidth = 5;
            
            graphics = panel_PaintCanvas.CreateGraphics();
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            

            pen = new Pen(penColor, penWidth);

            aboutForm about = new aboutForm();
            about.Activate();
            about.Show();
            about.Focus();
        }

        private void ResolveColors()
        {
            for (int i = 0; i < 174; i++)
            {
                knownColors.Add(Enum.GetValues<KnownColor>()[i]);
            }

            foreach (var kc in knownColors)
            {
                actualColors.Add(Color.FromKnownColor(kc));
            }

            foreach (var c in actualColors)
            {
                combo_PenColor.Items.Add(c);
                combo_BackgroundColor.Items.Add(c);
            }
        }

        
        
        
        
        // Handle Input, and Drawing
        private void panel_PaintCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;
            x = e.X;
            y = e.Y;
        }
        private void panel_PaintCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;
            x = -1;
            y = -1;
        }
        private void panel_PaintCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isDrawing || x == -1 || y == -1) return;
            
            graphics.DrawLine(pen, new Point(x, y), e.Location);
            x = e.X;
            y = e.Y;
            
            
            
            
        }
        
        
        
        
        
        // Change Pen Property Methods
        private void SetNewPenColor(Color color)
        {
            penColor = color;
            UpdatePen();
        }

        private void SetNewBGColor(Color color)
        {
            bgColor = color;
            UpdatePen();
        }
        private void SetNewPenWidth(float width)
        {
            penWidth = width;
            UpdatePen();
        }
        private void UpdatePen()
        {
            panel_PaintCanvas.BackColor = bgColor;
            pen.Color = penColor;
            pen.Width = penWidth;
        }

        
        
        
        
        // Form Control Event Handlers => Changing Pen Properties
        private void combo_PenColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected = combo_PenColor.SelectedItem;
            var selected_color = (Color) selected;
            SetNewPenColor(selected_color);
            /*  THIS IS FOR DEBUGGING TYPE-CONVERSION.
            var raw_selected_item = combo_PenColor.SelectedItem;
            var string_form = combo_PenColor.SelectedItem.ToString();
            var type_form = combo_PenColor.SelectedItem.GetType();

            MessageBox.Show("Raw Selected Item: " + raw_selected_item.ToString() + " & " + raw_selected_item.GetType());
            MessageBox.Show("String Form: " + string_form.ToString()+ " & " + string_form.GetType());
            MessageBox.Show("Type Form " + type_form.ToString()+ " & " + type_form.GetType());
            */

        }

        private void combo_BackgroundColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected = combo_BackgroundColor.SelectedItem;
            var selected_color = (Color) selected;
            SetNewBGColor(selected_color);        }

        private void txtbox_PenWidth_TextChanged(object sender, EventArgs e)
        {
            var text = txtbox_PenWidth.Text;

            if (int.TryParse(text, out var integerForm) != false)
            {
                SetNewPenWidth((float)integerForm);
            }
        }

        private void btn_SaveBitmap_Click(object sender, EventArgs e)
        {
            SaveToBitmap();
        }
        private void btn_NewCanvas_Click(object sender, EventArgs e)
        {
            graphics.Clear(bgColor);
        }

        //DEBUG
        private void SaveToBitmap()
        {
            
            Bitmap bitmap= new Bitmap(panel_PaintCanvas.Width, panel_PaintCanvas.Height-50, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            panel_PaintCanvas.DrawToBitmap(bitmap, panel_PaintCanvas.Bounds);
            Graphics copierGraphics = Graphics.FromImage(bitmap);
            copierGraphics.CopyFromScreen(PointToScreen(panel_PaintCanvas.Location).X, PointToScreen(panel_PaintCanvas.Location).Y, 0, 0, panel_PaintCanvas.Size, CopyPixelOperation.SourceCopy);
            
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Jpg Image|*.jpg|PNG Image|*.png|Bitmap Image|*.bmp", Title = "Save an Image File."
            };
            
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName == null)
            {
                MessageBox.Show("Please enter a file name.");
                return;
            }

            FileStream fileStream = (FileStream) saveFileDialog.OpenFile();

            switch (saveFileDialog.FilterIndex)
            {
                case 1:
                    bitmap.Save(fileStream, ImageFormat.Jpeg);
                    break;
                case 2:
                    bitmap.Save(fileStream, ImageFormat.Png);
                    break;
                case 3:
                    bitmap.Save(fileStream, ImageFormat.Bmp);
                    break;
                
            }






        }


        
    }
}