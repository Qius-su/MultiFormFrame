using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace GUI.UI
{
    public partial class Form5 : Form
    {

        private static Form5 formInstance;
        public static Form5 GetIntance
        {
            get
            {
                if (formInstance != null)
                {
                    return formInstance;
                }
                else
                {
                    formInstance = new Form5();
                    return formInstance;
                }
            }
        }
        public Form5()
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



        private void Form5_Load(object sender, EventArgs e)
        {

        }

    }
}
