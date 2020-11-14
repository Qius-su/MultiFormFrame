using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace GUI.UI
{
    public partial class Form7 : Form
    {

        private static Form7 formInstance;
        public static Form7 GetIntance
        {
            get
            {
                if (formInstance != null)
                {
                    return formInstance;
                }
                else
                {
                    formInstance = new Form7();
                    return formInstance;
                }
            }
        }
        public Form7()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 解决闪烁问题
        /// </summary>
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }
        public void SetBackgroudImage(string imageFileName)
        {
            this.BackgroundImage = System.Drawing.Image.FromFile(imageFileName);
        }



        private void Form7_Load(object sender, EventArgs e)
        {

        }

    }
}
