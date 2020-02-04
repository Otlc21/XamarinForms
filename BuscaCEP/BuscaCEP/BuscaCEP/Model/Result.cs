namespace BuscaCEP.Model
{
    public class Result
    {
        private bool sucess;
        private int code;
        private string description;

        public bool Sucess { get => sucess; set => sucess = value; }

        public int Code
        {
            get => code;
            set
            {
                if (value != 0)
                {
                    sucess = false;
                }

                code = value;
            }
        }

        public string Description { get => description; set => description = value; }


        public Result()
        {
            sucess = true;
        }

        public Result(string description)
        {
            sucess = false;
            this.description = description;
        }

        public Result(int code, string description)
        {
            sucess = false;
            this.code = code;
            this.description = description;
        }
    }
}
