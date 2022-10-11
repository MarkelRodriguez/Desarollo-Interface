namespace Console_Herentzia
{
    internal class B : A
    {

        public string prop3 { get; set; }
        public override string prop2
        {
            get => base.prop2;

            set
            {
                if (value.Length < 8)
                {
                    Exception ex = new Exception("Ez da zuzena");
                    throw ex;
                }
                else
                {

                    base.prop2 = value;
                }
            }
        }



        public override void Erakutsi()
        {
            Console.WriteLine("B klasea");
            Console.WriteLine("{0}, {1}, {2}", prop1, prop2, prop3);
        }

    }
}
