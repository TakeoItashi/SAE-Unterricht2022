using Models_and_Interfaces.Interfaces;
using Models_and_Interfaces.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Serialization
{
    public class XMLSerializerClass : ISerializer
    {
        public XMLSerializerClass()
		{

		}

        public void Serialize(Tile _objToSerialize, string _path)
		{
			XmlSerializer serializer = new XmlSerializer(typeof(Tile));

			using (StreamWriter writer = new StreamWriter(_path))
			{
				serializer.Serialize(writer, _objToSerialize);
			}
		}

        public void Deserialize()
		{

		}
    }
}
