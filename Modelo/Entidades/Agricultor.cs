namespace Modelo.Entidades
{
    public class Agricultor : Persona
    {
        private string apellido;
        private int dni;
        private string nroCuit;
        private List<Transporte> transportes;

        public int AgricultorID { get; set; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Dni { get => dni; set => dni = value; }
        public string NroCuit { get => nroCuit; set => nroCuit = value; }
        public List<Transporte> Transportes { get => transportes; set => transportes = value; }

        public override string ToString()
        {
            return $"{apellido} {Nombre}";
        }
    }
}
