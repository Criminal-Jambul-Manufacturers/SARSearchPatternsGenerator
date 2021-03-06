﻿using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace SARSearchPatternGenerator 
{
    /// <summary>
    /// Takes a pattern and writes it to a file in GPX format.
    /// </summary>
    class GPX : FileConverter
    {
        private Pattern p;


        /*
         * Takes a pattern to be stored in the file.
         */
        public GPX(Pattern p)
        {
            this.p = p;
        }



        /*
         * Saves the pattern GPX route file to a file path specified by name.
         */
        public void writeFile(String filePath)
        {
            Color[] colours = p.getColours();
            List<Coordinate> points = p.getPattern();
            Char delimiter = '.';
            String[] fileName = filePath.Split(delimiter);
            filePath = fileName[0];
            XmlWriter xmlWriter = startGPXfile(filePath + "_rte.gpx", points);

            writeWptFile(filePath);

            //Get just the name without the file path or file extension.
            String name = extractName(filePath);
            

            //open rte tag
            xmlWriter.WriteStartElement("rte");
                        //open name tag
                        xmlWriter.WriteStartElement("name");
                            xmlWriter.WriteString(name);
                        //close name tag
                        xmlWriter.WriteEndElement();
                        //open extensions tag
                        xmlWriter.WriteStartElement("extensions");
                            //open gpxx:RouteExtension tag
                            xmlWriter.WriteStartElement("gpxx", "RouteExtension", "http://www.garmin.com/xmlschemas/GpxExtensions/v3");
                                //open gpxx:IsAutoNamed
                                xmlWriter.WriteStartElement("gpxx", "IsAutoNamed", null);
                                    xmlWriter.WriteString("false");
                                //close gpxx:IsAutoNamed
                                xmlWriter.WriteEndElement();
                                //open gpxx:DisplayColor
                                xmlWriter.WriteStartElement("gpxx", "DisplayColor", null);
                                    xmlWriter.WriteString("Magenta");
                                //close gpxx:DisplayColor
                                xmlWriter.WriteEndElement();
                            //close gpxx:RouteExtension tag
                            xmlWriter.WriteEndElement();
                        //close extensions tag
                        xmlWriter.WriteEndElement();

                     String dateTime = DateTime.Now.ToString("hh:mm dd-MMM-yy");  //Formatting the dateTime for <cmt></cmt> and <desc></desc>

                //LOOP TIME!! yay
                for (int i = 0; i < points.Count; i++)
                {
                    //open extensions tag
                    xmlWriter.WriteStartElement("extensions");
                        //open gpxx:RouteExtension tag
                        xmlWriter.WriteStartElement("gpxx", "RouteExtension", "http://www.garmin.com/xmlschemas/GpxExtensions/v3");
                        //open gpxx:DisplayColor
                        xmlWriter.WriteStartElement("gpxx", "DisplayColor", null);
                                    xmlWriter.WriteString(selectColour(colours[(i) % colours.Length]));
                                    //close gpxx:DisplayColor
                                    xmlWriter.WriteEndElement();
                        //close gpxx:RouteExtension tag
                        xmlWriter.WriteEndElement();
                    //close extensions tag
                    xmlWriter.WriteEndElement();
                        //open rtept tag
                        xmlWriter.WriteStartElement("rtept");
                        xmlWriter.WriteAttributeString("lat", System.Convert.ToString(points[i].getLat()));
                        xmlWriter.WriteAttributeString("lon", System.Convert.ToString(points[i].getLng()));
                            //open name tag
                            xmlWriter.WriteStartElement("name");
                                    if (i > 0)
                                        xmlWriter.WriteString(name + System.Convert.ToString(i));
                                    else
                                        xmlWriter.WriteString(name);
                            //close name tag
                            xmlWriter.WriteEndElement();
                            //open cmt tag
                            xmlWriter.WriteStartElement("cmt");
                                    xmlWriter.WriteString(dateTime);
                            //close cmt tag
                            xmlWriter.WriteEndElement();
                            //open desc tag
                            xmlWriter.WriteStartElement("desc");
                                xmlWriter.WriteString(dateTime);
                            //close desc tag
                            xmlWriter.WriteEndElement();
                            //open sym tag
                            xmlWriter.WriteStartElement("sym");
                                xmlWriter.WriteString("Flag, " + "Blue");
                            //close sym tag
                            xmlWriter.WriteEndElement();

                            //open extensions tag
                            xmlWriter.WriteStartElement("extensions");
                                //open gpxx:RoutePointExtension tag
                                xmlWriter.WriteStartElement("gpxx", "RoutePointExtension", "http://www.garmin.com/xmlschemas/GpxExtensions/v3");
                                    //open gpxx:Subclass
                                    xmlWriter.WriteStartElement("gpxx", "Subclass", null);
                                        xmlWriter.WriteString("000000000000ffffffffffffffffffffffff");
                                    //close gpxx:Subclass
                                    xmlWriter.WriteEndElement();                   
                                //close gpxx:RoutePointExtension tag
                                xmlWriter.WriteEndElement();
                            //close extensions tag
                            xmlWriter.WriteEndElement();
                        //close rtept tag
                        xmlWriter.WriteEndElement();
                        

                }   //end loop

                //close rte tag
                xmlWriter.WriteEndElement();

            //close off the file
            endGPXfile(xmlWriter);
        }



        /*
         * Saves the GPX waypoint file to a file path specified by name.
         */
        private void writeWptFile(String filePath)
        {
            List<Coordinate> points = p.getPattern();
            XmlWriter xmlWriter = startGPXfile(filePath + "_wpt.gpx", points);
            String dateTime = DateTime.Now.ToString("hh:mm dd-MMM-yy");  //Formatting the dateTime for <cmt></cmt> and <desc></desc>
            Coordinate datum = p.getDatum();


            //open wpt tag
            xmlWriter.WriteStartElement("wpt");
            xmlWriter.WriteAttributeString("lon", System.Convert.ToString(points[0].getLng()));
            xmlWriter.WriteAttributeString("lat", System.Convert.ToString(points[0].getLat()));
            //open name tag
            xmlWriter.WriteStartElement("name");
            xmlWriter.WriteString("Start");
            //close name tag
            xmlWriter.WriteEndElement();
            //open cmt tag
            xmlWriter.WriteStartElement("cmt");
            xmlWriter.WriteString(dateTime);
            //close cmt tag
            xmlWriter.WriteEndElement();
            //open desc tag
            xmlWriter.WriteStartElement("desc");
            xmlWriter.WriteString(dateTime);
            //close desc tag
            xmlWriter.WriteEndElement();
            //open sym tag
            xmlWriter.WriteStartElement("sym");
            xmlWriter.WriteString("Flag, " + "Blue");
            //close sym tag
            xmlWriter.WriteEndElement();
            //close wpt tag
            xmlWriter.WriteEndElement();


            //open wpt tag
            xmlWriter.WriteStartElement("wpt");
            xmlWriter.WriteAttributeString("lon", System.Convert.ToString(datum.getLng()));
            xmlWriter.WriteAttributeString("lat", System.Convert.ToString(datum.getLat()));
            //open name tag
            xmlWriter.WriteStartElement("name");
            xmlWriter.WriteString("Datum");
            //close name tag
            xmlWriter.WriteEndElement();
            //open cmt tag
            xmlWriter.WriteStartElement("cmt");
            xmlWriter.WriteString(dateTime);
            //close cmt tag
            xmlWriter.WriteEndElement();
            //open desc tag
            xmlWriter.WriteStartElement("desc");
            xmlWriter.WriteString(dateTime);
            //close desc tag
            xmlWriter.WriteEndElement();
            //open sym tag
            xmlWriter.WriteStartElement("sym");
            xmlWriter.WriteString("Flag, " + "Red");
            //close sym tag
            xmlWriter.WriteEndElement();
            //close wpt tag
            xmlWriter.WriteEndElement();

            //close off the file
            endGPXfile(xmlWriter);

        }



        /*
         *  Formats the xml file with indentation and creates the file.  
         *  Returns the xmlWriter object which we are writing to.
         */ 
        private XmlWriter startGPXfile(String name, List<Coordinate> points)
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.IndentChars = "\t";
            //CREATE THE FILE
            XmlWriter xmlWriter = XmlWriter.Create(name, settings);  //Makes file and formats indentation
            xmlWriter.WriteStartDocument();

            //open gpx tag
            xmlWriter.WriteStartElement("gpx", "http://www.topografix.com/GPX/1/1");
            xmlWriter.WriteAttributeString("xmlns", "", null, "http://www.topografix.com/GPX/1/1");
            xmlWriter.WriteAttributeString("creator", "MapSource 6.14.1");
            xmlWriter.WriteAttributeString("version", "1.1");
            xmlWriter.WriteAttributeString("xmlns", "xsi", null, "http://www.w3.org/2001/XMLSchema-instance");
            xmlWriter.WriteAttributeString("xsi", "schemaLocation", null, "http://www.garmin.com/xmlschemas/GpxExtensions/v3" +
                " http://www.garmin.com/xmlschemas/GpxExtensionsv3.xsd http://www.topografix.com/GPX/1/1" +
                " http://www.topografix.com/GPX/1/1/gpx.xsd");
            //open metadata tag
            xmlWriter.WriteStartElement("metadata");
            //open link tag
            xmlWriter.WriteStartElement("link");
            xmlWriter.WriteAttributeString("href", "http://www.garmin.com");
            //open text tag
            xmlWriter.WriteStartElement("text");
            xmlWriter.WriteString("Garmin International");
            //close text tag
            xmlWriter.WriteEndElement();
            //close link tag
            xmlWriter.WriteEndElement();
            //open time tag
            xmlWriter.WriteStartElement("time");
            //GET THE DATE TIME in correct format
            String dateTime = DateTime.Now.ToString("yyyy-MM-ddThh:mm:ssZ");
            //Write DateTime string
            xmlWriter.WriteString(dateTime);
            //close time tag
            xmlWriter.WriteEndElement();
            //open bounds tag
            xmlWriter.WriteStartElement("bounds");
            xmlWriter.WriteAttributeString("maxlat", System.Convert.ToString(p.maxLat()));
            xmlWriter.WriteAttributeString("maxlon", System.Convert.ToString(p.maxLong()));
            xmlWriter.WriteAttributeString("minlat", System.Convert.ToString(p.minLat()));
            xmlWriter.WriteAttributeString("minlon", System.Convert.ToString(p.minLong()));
            //close bounds tag
            xmlWriter.WriteEndElement();
            //close metadata tag
            xmlWriter.WriteEndElement();

            return xmlWriter;
        }


        /*
         *  Saftely closes off the GPX file that we are writing to.
         */
        private void endGPXfile(XmlWriter xmlWriter)
        {
            //close GPX tag
            xmlWriter.WriteEndElement();

            //End the file.
            xmlWriter.WriteEndDocument();
            xmlWriter.Close();
        }

    }
}
