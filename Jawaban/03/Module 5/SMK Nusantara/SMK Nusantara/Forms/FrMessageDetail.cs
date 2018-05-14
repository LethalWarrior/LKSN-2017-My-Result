using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SMK_Nusantara.Database;
using SMK_Nusantara.Classes;

namespace SMK_Nusantara.Forms
{
    public partial class FrMessageDetail : Form
    {
        public FrMessageDetail(Database.Message message)
        {
            InitializeComponent();
            this.message = message;
        }

        Database.Message message;

        private void FrMessageDetail_Load(object sender, EventArgs e)
        {
            TbxContent.Text = message.Content;
        }
    }
}
