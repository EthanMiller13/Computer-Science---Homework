namespace Exc2
{
    class Program{
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter properties for file No. 1:");
            Console.Write("Name: ");
            string name1 = Console.ReadLine();
            Console.Write("Type: ");
            string type1 = Console.ReadLine();
            Console.Write("Size: ");
            double size1 = double.Parse(Console.ReadLine());
            Console.Write("Date of creation: ");
            string dateOfCreation1 = Console.ReadLine();
            Console.Write("Is it open? ");
            bool isOpen1 = bool.Parse(Console.ReadLine());
            Console.Write("Content: ");
            string content1 = Console.ReadLine();
            File file1 = new File(name1, type1, size1, dateOfCreation1, isOpen1, content1);

            Console.WriteLine("\nEnter properties for file No. 2:");
            Console.Write("Name: ");
            string name2 = Console.ReadLine();
            Console.Write("Type: ");
            string type2 = Console.ReadLine();
            Console.Write("Size: ");
            double size2 = double.Parse(Console.ReadLine());
            Console.Write("Date of creation: ");
            string dateOfCreation2 = Console.ReadLine();
            Console.Write("Is it open? ");
            bool isOpen2 = bool.Parse(Console.ReadLine());
            Console.Write("Content: ");
            string content2 = Console.ReadLine();
            File file2 = new File(name2, type2, size2, dateOfCreation2, isOpen2, content2);
            if(file1.Type == file2.Type){
                Console.WriteLine("Both files have the same type");
                file1.IsOpen = true;
                file2.IsOpen = true;
                Console.WriteLine("Enter a new file name: ");
                string newFileName = Console.ReadLine();
                File newFile = new File(newFileName, file1.Type, file1.Size+file2.Size, "---", true, file1.Content + file2.Content);
                Console.WriteLine("newFile: " + newFile.ToString());
                newFile.IsOpen = false;
            }else{
                Console.WriteLine("The files are from different types.");
            }
            
            file1.IsOpen = false;
            file2.IsOpen = false;
            //Console.WriteLine("File1: " + file1.ToString());
            //Console.WriteLine("File2: " + file2.ToString());
        }
    }

    public class File{
        private string _name;
        public string Name {
            get { return this._name; }
            set { this._name = value; }
        }

        private string _type;
        public string Type {
            get { return this._type; }
            set { this._type = value; }
        }
        private double _size;
        public double Size {
            get { return this._size; }
            set { this._size = value; }
        }
        private string _dateOfCreation;
        public string DateOfCreation {
            get { return this._dateOfCreation; }
            set { this._dateOfCreation = value; }
        }
        private bool _isOpen;
        public bool IsOpen {
            get { return this._isOpen; }
            set { this._isOpen = value; }
        }

        private string _content;
        public string Content {
            get { return this._content; }
            set { this._content = value; }
        }

        public File(string name, string type, double size, string dateOfCreation, bool isOpen, string content)
        {
            this._name = name;
            this._type = type;
            this._size = size;
            this._dateOfCreation = dateOfCreation;
            this._isOpen = isOpen;
            this._content = content;
        }
        public bool isEqualType(File file){
            return this._type == file.Type;
        }

        public override string ToString(){
            return $"File(Name: {this._name}, Type: {this._type}, Size: {this._size}, DateOfCreation: {this._dateOfCreation}, IsOpen: {this._isOpen}, Content: {this._content})";
        }
    }
}