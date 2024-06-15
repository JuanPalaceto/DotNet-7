using System.Xml.Serialization; // [XmlAttribute] => Convertir las etiquetas en atributos. <FirstName></FirstName> => <Person fname="..."/>

namespace Packt.Shared;

public class Person
{
    public Person(decimal initialSalary)
    {
        Salary = initialSalary;
    }

    // Es necesario para que el serializer pueda instanciar objetos de este tipo durante la deserialización
    public Person() { }

    [XmlAttribute("fname")]
    public string? FirstName { get; set; }
    [XmlAttribute("lname")]
    public string? LastName { get; set; }
    [XmlAttribute]
    public DateTime DateOfBirth { get; set; }
    public HashSet<Person>? Children { get; set; }
    // No será serializada ya que no es una prop publica
    protected decimal Salary { get; set; }
}