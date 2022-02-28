namespace Web2._1.Models
{
    public class CalcDataViewModel
    {
        public int a;
        public int b;
        public string Add;
        public string Sub;
        public string Mult;
        public string Div;

        public CalcDataViewModel(int a, int b)
        {
            this.a = a; this.b = b;
            Add = (a + b).ToString();
            Sub = (a - b).ToString();
            Mult = (a * b).ToString();
            Div = b != 0 ? (a / b).ToString() : "Infinity";
        }
    }
}
