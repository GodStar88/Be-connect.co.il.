using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Be_connect.co.il
{
    class CFormControl
    {
        public void waitTimeOut(int time)
        {
            FormText(" Waiting " + time.ToString() + "s");
            System.Threading.Thread.Sleep(1000);
        }

        public void FormText(string str)
        {
            try { Form1.Instance.TextStatus = str; } catch (Exception) { }
        }

        public void checkAll(DataGridView dataGridView, CheckBox checkbox)
        {
            if (checkbox.CheckState.ToString() == "Checked")
            {
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    dataGridView.Rows[i].Cells[0].Value = true;
                }
            }
            else
            {
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    dataGridView.Rows[i].Cells[0].Value = false;
                }
            }
        }
        public void gridRowsDelete(DataGridView dataGridView)
        {
            for (int i = dataGridView.Rows.Count - 1; i >= 0; i--)
            {
                if (Convert.ToBoolean(dataGridView.Rows[i].Cells[0].Value)) dataGridView.Rows.RemoveAt(i);
            }
        }
    }
}
