namespace Aula02
{
    public partial class CadastroAluno : Form
    {
        List<Aluno> listaAlunos = new List<Aluno>();
        public CadastroAluno()
        {
            InitializeComponent();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno();
            aluno.id = int.Parse(txt_alunocod.Text);
            aluno.nome = txt_nome.Text;
            //aluno.RM = txt_rm.Text;

            listaAlunos.Add(aluno);
            txt_alunocod.Text = string.Empty;
            txt_nome.Text = string.Empty;
            txt_rm.Text = string.Empty;
            MessageBox.Show("Aluno Cadastrado com Sucesso.","FIAP");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
