using UnityEngine;
using System.Collections;
using System.Xml;
using System.Xml.Serialization;

public class Math_problems{

    [XmlAttribute("problemID")]
    public string problemID;

    [XmlElement("equation")]
    public string equation;

    [XmlElement("answer")]
    public string answer;


}
