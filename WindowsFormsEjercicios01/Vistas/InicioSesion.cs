using WindowsFormsEjercicios01.Controladores;

namespace WindowsFormsEjercicios01
{
    public partial class InicioSesion : Form
    {
        public InicioSesion()
        {
            InitializeComponent();
        }

        public void InicioSesion_Load(object sender, EventArgs e)
        {
            DataUsers.populateUserlist(DataUsers.userlist);
        }
    }
}
