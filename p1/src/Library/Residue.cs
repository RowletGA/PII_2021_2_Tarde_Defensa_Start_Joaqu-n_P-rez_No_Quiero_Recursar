namespace Ucu.Poo.Defense
{
    public class Residue
    {
        public string Name { get; set; }

        public ResidueType Type { get; set; }
        /// <summary>
        /// instancio booleano que concuerda con los Test y se da el Get el retorno del mismo
        /// </summary>
        /// <value></value>
        public bool IsOrganic 
        { 
            get{
                return this.Type.IsOrganic; 
            }
        }

        public Residue(string name, ResidueType type)
        {
            this.Name = name;
            this.Type = type;
        }
    }
}