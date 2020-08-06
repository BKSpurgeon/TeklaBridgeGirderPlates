﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tekla.Structures.Geometry3d;
using Tekla.Structures.Model;

namespace ContourPlateBridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Model teklaModel = new Model();

            if (teklaModel.GetConnectionStatus())
            {
                //Read in Width and length from CSV file
                // Put 20 plates in 1 row. Use a space of 300 between plates.
                // Name into the name field

                double aWidth = 470;
                double bLength = 570;
                string name = "B81-P09-BER-01";
                string profile = "PL32";

                    // we're going counter clock wise
                ContourPoint p1 = new ContourPoint(new Point(0, 0, 0), new Chamfer(0,0, Chamfer.ChamferTypeEnum.CHAMFER_LINE));
                p1.Chamfer.DZ1 = -12;
                
                ContourPoint p2 = new ContourPoint(new Point(aWidth, 0, 0), new Chamfer(0, 0, Chamfer.ChamferTypeEnum.CHAMFER_LINE));
                p2.Chamfer.DZ1 = -6;

                ContourPoint p3 = new ContourPoint(new Point(aWidth, bLength, 0), new Chamfer(0, 0, Chamfer.ChamferTypeEnum.CHAMFER_LINE));
                p3.Chamfer.DZ1 = 0;

                ContourPoint p4 = new ContourPoint(new Point(0, bLength, 0), new Chamfer(0, 0, Chamfer.ChamferTypeEnum.CHAMFER_LINE));
                p4.Chamfer.DZ1 = -6;
                
                ContourPlate contourPlate = new ContourPlate();
                contourPlate.AddContourPoint(p1);
                contourPlate.AddContourPoint(p2);
                contourPlate.AddContourPoint(p3);
                contourPlate.AddContourPoint(p4);

                contourPlate.Finish = "HDG";
                contourPlate.Profile.ProfileString = profile;
                contourPlate.Material.MaterialString = "250";
                contourPlate.Name = name;
                contourPlate.Position.Depth = Position.DepthEnum.FRONT;

                contourPlate.Insert();
            }

            teklaModel.CommitChanges();
        }
    }
}
