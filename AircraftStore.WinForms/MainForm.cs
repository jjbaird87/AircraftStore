using System;
using System.Windows.Forms;
using AircraftStore.Dal.Data;
using AircraftStore.WinForms.Views;

namespace AircraftStore.WinForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            System.Data.Entity.Database.SetInitializer(new SampleData());
            ChangeView<UcLogin>();
        }

        public void LoadAdminConsole()
        {
            ChangeView<UcAdmin>();
        }


        private void ChangeView<T>() where T : Control, new()
        {
            try
            {
                if (controlContainer.IsHandleCreated)
                    controlContainer.Invoke((MethodInvoker)(SelectForm<T>));
                else
                    SelectForm<T>();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SelectForm<T>() where T : Control, new()
        {
            Control find = Find<T>(controlContainer) ?? new T { Parent = controlContainer, Dock = DockStyle.Fill };            
            find.BringToFront();

            if (find.Name == "UcLogin")
            {
                var loginControl = find as UcLogin;
                if (loginControl != null)
                {
                    loginControl.MainForm = this;
                }
            }
        }

        static T Find<T>(Control container) where T : Control
        {
            for (var i = 0; i < container.Controls.Count; i++)
            {
                var find = container.Controls[i] as T;
                if (find != null)
                {
                    return find;
                }
            }
            return null;
        }
    }
}
