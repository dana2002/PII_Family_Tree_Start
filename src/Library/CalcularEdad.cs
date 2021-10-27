namespace Library
{
  public class CalcularEdad : Visitador
  {
    
    private int sumar = 0;
    public int Sumar{get; set;}

    public override void Visitor(Node node)
    {
      this.Sumar += node.Persona.Edad;
      foreach(Node n in node.Children)
      {
        this.Visitor(n);
      }
    }
  }
}