using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml;

namespace SARSearchPatternGenerator
{
    /*
     *  This class has the sole purpose of being a Controller of the main Window. 
     */
    public class WindowController
    {
        Window mainWindow;

        /*
        * Constructor for this WindowController class.  It starts running the main Window. 
        */
        public WindowController() {
            //This is what STARTS the main window.
            mainWindow = new Window();
            mainWindow.setController(this);
            writeSystemText("Program loaded");

            this.onProgramStart();
            Application.Run(mainWindow);

        }
        
        private void writeSystemText(string txt)
        {
            mainWindow.setSystemLabel(txt);
        }

        public void onFileNew()
        {
            PatternController pc = new PatternController();
            mainWindow.setDisplay(pc);
            pc.defaultInitialize();
            mainWindow.unitChange();
            mainWindow.coordSystemChange();
            writeSystemText("New pattern created");
        }
        public void createFromPattern(SavedData sd, Pattern p)
        {
            this.mainWindow.setSelectedUnitType(sd.unitSystem);
            this.mainWindow.setSelectedCoordType(sd.coordinateSystem);
            PatternController pc = new PatternController();
            mainWindow.setDisplay(pc);
            pc.defaultInitialize();
            mainWindow.unitChange();
            mainWindow.coordSystemChange();
            pc.createFromPattern(sd.patternType, p);
            pc.loadData(sd);
            writeSystemText("Pattern Loaded");
        }
        public void onClose()
        {
            Pattern p = mainWindow.getCurrentPattern();
            if (p != null) {
                FileStream fStream = null;
                try
                {
                    DataContractSerializer dcs = new DataContractSerializer(p.GetType());
                    fStream = new FileStream(".\\pattern.xml", FileMode.Create);
                    dcs.WriteObject(fStream, p);

                    if (this.mainWindow.getDisplay() != null)
                    {
                        fStream.Close();
                        dcs = new DataContractSerializer(typeof(FileMode));
                        fStream = new FileStream(".\\misc.xml", FileMode.Create);
                        SavedData sd = this.mainWindow.getDisplay().getSavedData();
                        dcs = new DataContractSerializer(sd.GetType());
                        dcs.WriteObject(fStream, sd);
                    }
                }
                finally
                {
                    if (fStream != null)
                    {
                        fStream.Close();
                    }
                }
            }
            Console.WriteLine("Program closed");
        }
        public void onProgramStart()
        {
            FileStream fStream = null;
            try
            {
                DataContractSerializer dcs = new DataContractSerializer(typeof(Pattern));
                fStream = new FileStream(".\\pattern.xml", FileMode.Open);
                Pattern p = (Pattern)dcs.ReadObject(XmlReader.Create(fStream), false);
                fStream.Close();

                dcs = new DataContractSerializer(typeof(SavedData));
                fStream = new FileStream(".\\misc.xml", FileMode.Open);
                SavedData sd = (SavedData)dcs.ReadObject(XmlReader.Create(fStream), false);
                createFromPattern(sd, p);
            }
            catch (FileNotFoundException)
            {
                writeSystemText("Previous data not found");
            }
            catch (SerializationException)
            {
                writeSystemText("Problem reading previous data");
            }
            finally
            {
                if (fStream != null)
                {
                    fStream.Close();
                }
            }
        }
    }
}
