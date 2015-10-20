using System.Linq;
using System.Windows.Forms;
using AircraftStore.WinForms.Account;

namespace AircraftStore.WinForms.Views
{
    public partial class UcAdmin : UserControl
    { 
        public UcAdmin()
        {
            InitializeComponent();
            
            chkListRoles.DataSource = DataHelper.GetRoles();
            cmbUsers.DataSource = DataHelper.GetLoginUsers();
            dataGridViewUsers.DataSource = DataHelper.GetFullUsers();
            dataGridViewUsers.Refresh();
        }

        private void entityBindingNavigator1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

            aircraftDataGridView.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void entityDataSource1_DataError(object sender, EFWinforms.DataErrorEventArgs e)
        {
            MessageBox.Show($"Error Detected:\r\n {e.Exception.Message}");
            entityDataSource1.CancelChanges();
            e.Handled = true;
        }

        private void entityBindingNavigator2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            dataGridViewManufacturers.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void entityBindingNavigator3_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            dataGridViewTypes.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void cmbUsers_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (cmbUsers.SelectedIndex == -1) return;
            UncheckAll();

            var user = (LoginUser)cmbUsers.SelectedItem;
            foreach (var role in user.Roles)
            {
                for (var i = 0; i < chkListRoles.Items.Count; i++)
                {
                    var localRole = (Role)chkListRoles.Items[i];
                    if (localRole.Id == role.Id)
                        chkListRoles.SetItemChecked(i, true);
                }                    
            }
        }

        private void UncheckAll()
        {
            for (var i = 0; i < chkListRoles.Items.Count; i++)
            {
                chkListRoles.SetItemCheckState(i, CheckState.Unchecked);                
            }
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            if (cmbUsers.SelectedIndex==-1)
                return;

            var user = (LoginUser)cmbUsers.SelectedItem;
            foreach (var role in user.Roles)
            {
                user.RemoveFromRole(role.Name);
            }
            
            foreach (var role in chkListRoles.SelectedItems.Cast<Role>())
            {
                user.AddToRole(role.Name);
            }

            MessageBox.Show(@"Roles saved successfully");
        }
    }
}
