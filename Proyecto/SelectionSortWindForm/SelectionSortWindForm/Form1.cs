namespace SelectionSortWindForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            string datos = txtDatos.Text;
            string[] DatosArray = datos.Split(',');
            int[] numeros = Array.ConvertAll(DatosArray, int.Parse);

            SelectionSort(numeros);

            lblResultado.Text = "Datos Ordenados " + string.Join(", ", numeros);
        }



        private void SelectionSort(int[] arr)
        {
            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int min = i;

                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        min = j;
                    }
                }

                int temp = arr[min];
                arr[min] = arr[i];
                arr[i] = temp;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtDatos.Clear();
            lblResultado.Text = "";
        }
    }
}
