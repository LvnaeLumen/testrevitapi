#region Namespaces
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

#endregion

namespace TestTask2
{
    [Transaction(TransactionMode.Manual)]    
    public class Command : IExternalCommand
    {
        public Result Execute(
          ExternalCommandData commandData,
          ref string message,
          ElementSet elements)
        {
            UIApplication uiapp = commandData.Application;
            Document doc = uiapp.ActiveUIDocument.Document;
            //�������� ��������?

            //ICollection<Element> targetFamily;

            FilteredElementCollector col
              = new FilteredElementCollector(doc);


            FamilyDataChange win = new FamilyDataChange(); //��������� ����
            
            win.ShowDialog();
            var selected_familty = win.FamilyName;//�������� ���������� ������
            var selected_param = win.ParameterName; //�������� ��� ������
                                                    //������� ����������� �������� ���������� �����
            //����� ����� ���������� ����� ���������
            //������� ���� �� ������
         

            return Result.Succeeded;
        }
    }
}
