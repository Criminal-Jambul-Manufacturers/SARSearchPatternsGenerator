using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SARSearchPatternGenerator.coords;

namespace SARSearchPatternGenerator
{
    /*
     * The PatternController class controls the display for viewing
     * a pattern. This controller handles inputs such as changing
     * values for the pattern and changing the coordinate system.
    */
    public class PatternController : DisplayController
    {
        private PatternDisplay display;
        private string unitName;
        private DistanceUnit unit;
        private String patternFileName = "parallel_";
        private Pattern pattern;
        private string[] patternComments;
        private int coordSystemID = 0;

        public PatternController()
        {
            display = new PatternDisplay();
            display.setController(this);
            patternComments = new string[4];
        }

        private String getTimestamp()
        {
            String dateTime = DateTime.Now.ToString("dd-MMM-yyyy-hh-mm");
            return dateTime;
        }

        public void setPattern(Pattern p)
        {
            pattern = p;
        }

        public void createFromPattern(int index, Pattern p)
        {
            this.display.setSelectedPattern(index);
            setPattern(p);
            changePattern(index, p);
        }

        public void loadData(SavedData sd)
        {
            if (this.patternComments != null)
            {
                patternComments[0] = sd.ExpandingSquareComment == "" ?
                    (string)DefaultComments.ResourceManager.GetObject("ExpandingSquareComment") :
                    sd.ExpandingSquareComment;
                patternComments[1] = sd.SectorSearchComment == "" ?
                    (string)DefaultComments.ResourceManager.GetObject("SectorSearchComment") :
                    sd.SectorSearchComment;
                patternComments[2] = sd.ParallelTrackComment == "" ?
                    (string)DefaultComments.ResourceManager.GetObject("ParallelTrackComment") :
                    sd.ParallelTrackComment;
                patternComments[3] = sd.PointToPointComment == "" ?
                    (string)DefaultComments.ResourceManager.GetObject("PointToPointComment") :
                    sd.PointToPointComment;
            }
            updateDisplayComment();
        }

        public override SavedData getSavedData()
        {
            SavedData sd = new SavedData();
            if (this.patternComments != null)
            {
                sd.ExpandingSquareComment = patternComments[0];
                sd.SectorSearchComment = patternComments[1];
                sd.ParallelTrackComment = patternComments[2];
                sd.PointToPointComment = patternComments[3];
            }
            sd.unitSystem = this.unit.getID();
            sd.coordinateSystem = this.coordSystemID;
            sd.patternType = this.display.getSelectedPatternIndex();
            return sd;
        }

        private void updateDisplayComment()
        {
            if (display != null)
            {
                switch (this.display.getSelectedPatternIndex())
                {
                    case 0:
                        display.setComment(patternComments[0]);
                        break;
                    case 1:
                        display.setComment(patternComments[1]);
                        break;
                    case 2:
                        display.setComment(patternComments[2]);
                        break;
                    case 3:
                        display.setComment(patternComments[3]);
                        break;
                }
            }
        }

        public void onCommentChanged(string newText)
        {
            if (display != null)
            {
                patternComments[this.display.getSelectedPatternIndex()] = newText;
            }
        }

        public void updatePatternComments(int index, string newComment)
        {
            patternComments[index] = newComment;
        }

        public void defaultInitialize()
        {
            expandingSquareSetup();
        }

        private void expandingSquareSetup()
        {
            ExpandingSquareInput eei = new ExpandingSquareInput();
            display.setInputGroup(eei);
            display.setPatternImage("ExpandingSquare_SearchPattern2");
            display.setPatternText("Expanding Square");
            setPattern(eei.getPattern());
        }

        private void sectorSearchSetup()
        {
            SectorSearchInput ssi = new SectorSearchInput();
            display.setInputGroup(ssi);
            display.setPatternImage("SectorSearchPattern_3LegAircraft2");
            display.setPatternText("Sector Search");
            setPattern(ssi.getPattern());
        }

        private void parallelSearchSetup()
        {
            ParallelSearchInput pss = new ParallelSearchInput();
            display.setInputGroup(pss);
            display.setPatternImage("ParallelTrack_SearchPattern2");
            display.setPatternText("Parallel Search");
            setPattern(pss.getPattern());
        }

        private void pointToPointSetup()
        {
            PointToPointInput ptpi = new PointToPointInput();
            display.setInputGroup(ptpi);
            display.setPatternImage("TracklineSearch2");
            display.setPatternText("Point-to-Point");
            setPattern(ptpi.getPattern());
        }

        public void changePattern(int index, Pattern p)
        {
            switch(index)
            {
                case 0:
                    expandingSquareSetup();
                    patternFileName = "expanding_";
                    break;
                case 1:
                    sectorSearchSetup();
                    patternFileName = "sector_";
                    break;
                case 2:
                    parallelSearchSetup();
                    patternFileName = "parallel_";
                    break;
                case 3:
                    pointToPointSetup();
                    patternFileName = "ptop_";
                    break;
            }
            display.updateFieldsFromPattern(p);
            updateDisplayComment();
        }

        public override void onUnitChange(int index)
        {
            unitName = "nm";
            unit = NauticalMiles.create();
            switch(index)
            {
                case 1:
                    unitName = "mi";
                    unit = Miles.create();
                    break;
                case 2:
                    unitName = "ft";
                    unit = Feet.create();
                    break;
                case 3:
                    unitName = "km";
                    unit = Kilometers.create();
                    break;
                case 4:
                    unitName = "m";
                    unit = Meters.create();
                    break;
            }
            if (display != null)
            {
                display.changeUnitSystem(unitName, unit);
            }
        }

        public void recalcInfo(double searchSpeed, double sweepWidth)
        {
            pattern.calculatePatternInfo(searchSpeed, sweepWidth);
            display.updatePatternInfo(pattern);
        }

        public string getUnitName()
        {
            return unitName;
        }

        public DistanceUnit getUnit()
        {
            return unit;
        }

        public override void onCoordSystemChange(int index)
        {
            this.coordSystemID = index;
            switch(index)
            {
                case 0:
                    display.changeCoordinateSystem(CoordSystem.DecDeg);
                    break;
                case 1:
                    display.changeCoordinateSystem(CoordSystem.DegDecMin);
                    break;
                case 2:
                    display.changeCoordinateSystem(CoordSystem.DegMinSec);
                    break;
                case 3:
                    display.changeCoordinateSystem(CoordSystem.UTMCoord);
                    break;
            }
        }

        public override UserControl getDisplay()
        {
            return display;
        }

        public void exportGPX(Pattern p)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "GPX files(*.gpx)|*.gpx";
            sf.FileName = patternFileName + getTimestamp();


            if (sf.ShowDialog() == DialogResult.OK)
            {
                GPX gpx = new GPX(p);
                gpx.writeFile(sf.FileName);
            }
        }
        public void exportKML(Pattern p)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "KML files(*.kml)|*.kml";
            sf.FileName = patternFileName + getTimestamp();

            if (sf.ShowDialog() == DialogResult.OK)
            {
                double altitude = display.getKMLAltitude();
                int modeIndex = display.getKMLModeIndex();
                KML kml = new KML(p);
                switch (modeIndex)
                {
                    case 0:
                        kml.airModeOff();
                        break;
                    case 1:
                        kml.airModeOn();
                        kml.setAltitude(altitude);
                        break;
                }
                kml.writeFile(sf.FileName);
            }
        }
        public override Pattern getPattern()
        {
            return this.pattern;
        }

        public override string getComment()
        {
            return this.display.getComment();
        }
    }
}
