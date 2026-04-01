using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsLab.views;

namespace WindowsLab
{
    public partial class WindowFrom : Form
    {
        private Button _activeNavButton;
        private readonly Color NavNormalBack = Color.FromArgb(244, 244, 246);
        private readonly Color NavActiveBack = Color.FromArgb(153, 153, 161);
        private readonly Color NavNormalForce = Color.Black;
        private readonly Color NavActiveForce = Color.Black;

        private readonly Dictionary<Type, UserControl> _views = new Dictionary<Type, UserControl>();


        public WindowFrom()
        {
            InitializeComponent();
        }
        private void ShowViews<T>(Func<T> factory) where T : UserControl
        {

            var key = typeof(T);
            if (!_views.TryGetValue(key, out var view))
            {
                view = factory();
                _views[key] = view;
                view.Dock = DockStyle.Fill;
            }
            panelContent.Controls.Clear();
            panelContent.Controls.Add(view);
        }



        private void SetActiveNavButton(Button btn)
        {
            if (btn == null) return;

            // Reset the previous active button back to normal
            if (_activeNavButton != null)
            {
                _activeNavButton.BackColor = NavNormalBack;
                _activeNavButton.ForeColor = NavNormalForce;
                _activeNavButton.Font = new Font(_activeNavButton.Font, FontStyle.Regular);
            }

            // Set the new active button
            _activeNavButton = btn;
            _activeNavButton.BackColor = NavActiveBack;
            _activeNavButton.ForeColor = NavActiveForce;
            _activeNavButton.Font = new Font(_activeNavButton.Font, FontStyle.Bold);
            _activeNavButton.Padding = new Padding(4, 4, 4, 4);
        }
        private void DashboardClicked(object sender, EventArgs e)
        {
            SetActiveNavButton((Button)sender);
            panelContent.Controls.Clear();
            //panelContent.Controls.Add(new DashboardViews());
            ShowViews(() => new DashboardViews());

        }

        private void BtnProducts_Click(object sender, EventArgs e)
        {
            SetActiveNavButton((Button)sender);
            panelContent.Controls.Clear();
            //panelContent.Controls.Add(new ProductsView());
            ShowViews(() => new ProductsView());

        }

        private void BtnOrders_Click(object sender, EventArgs e)
        {
            SetActiveNavButton((Button)sender);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void BtnReports_Click(object sender, EventArgs e)
        {
            SetActiveNavButton((Button)sender);
        }

        private void BtnSyn_Click(object sender, EventArgs e)
        {

            SetActiveNavButton((Button)sender);
        }

        private void BtnLogs_Click(object sender, EventArgs e)
        {
            SetActiveNavButton((Button)sender);
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            SetActiveNavButton((Button)sender);
        }
    }
}
