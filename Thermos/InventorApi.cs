using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Inventor;
using Application = Inventor.Application;

namespace Thermos
{
    /// <summary>
    /// Inventor API.
    /// </summary>
    public class InventorApi
    {
        #region Fields

        /// <summary>
        /// Ссылка на приложение Инвентора.
        /// </summary>
        private Application _invApp;

        /// <summary>
        /// Документ в приложении.
        /// </summary>
        private PartDocument _partDoc;

        /// <summary>
        /// Описание документа.
        /// </summary>
        private PartComponentDefinition _partDef;

        /// <summary>
        /// Геометрия приложения.
        /// </summary>
        private TransientGeometry _transGeometry;

       /// <summary>
        /// Текущий скетч.
        /// </summary>
        private PlanarSketch _currentSketch;
        
      

        /// <summary>
        /// Индекс для масштабирования размеров.
        /// </summary>
        private const double Index = 10.0;
        
        #endregion

        #region Methods

        /// <summary>
        /// Инициализировать Инвентор и подготовить переменные.
        /// </summary>
        public InventorApi()
        {
            try
            {
                _invApp = (Application)Marshal.GetActiveObject("Inventor.Application");
            }
            catch (Exception)
            {
                try
                {
                    Type invAppType = Type.GetTypeFromProgID("Inventor.Application");

                    _invApp = (Application)Activator.CreateInstance(invAppType);
                    _invApp.Visible = true;

                    //Note: if the Inventor session is left running after this
                    //form is closed, there will still an be and Inventor.exe 
                    //running. We will use this Boolean to test in Form1.Designer.cs 
                    //in the dispose method whether or not the Inventor App should
                    //be shut down when the form is closed.

                }
                catch (Exception)
                {
                    //MessageBox.Show(ex2.ToString());
                    MessageBox.Show(@"Не удалось запустить инвентор.");
                }
            }

            // В открытом приложении создаем документ.
            _partDoc = (PartDocument)_invApp.Documents.Add 
                (DocumentTypeEnum.kPartDocumentObject,
                    _invApp.FileManager.GetTemplateFile
                        (DocumentTypeEnum.kPartDocumentObject,
                            SystemOfMeasureEnum.kMetricSystemOfMeasure));
          
            _partDef = _partDoc.ComponentDefinition;
            _transGeometry = _invApp.TransientGeometry; 
        }

        /// <summary>
        /// Создание плоскости переносом плоскостей ZY, ZX, XY.
        /// </summary>
        /// <param name="n">Номер плоскости: 1 - ZY, 2 - ZX, 3 - XY</param>
        /// <param name="offset">Относительное смещение плоскости</param>
        public void MakeNewWorkingPlane(int n, double offset)
        {
            var mainPlane = _partDef.WorkPlanes[2];
            var offsetPlane = _partDef.WorkPlanes.AddByPlaneAndOffset(mainPlane, offset / Index);
            _currentSketch = _partDef.Sketches.Add(offsetPlane);
        }

   

        /// <summary>
        /// Рисует круг.
        /// </summary>
        /// <param name="centerPointX">Координата X центра круга</param>
        /// <param name="centerPointY">Координата Y центра круга</param>
        /// <param name="diameter">Диаметр круга</param>
        public void DrawCircle(double centerPointX, double centerPointY, double diameter)
        {
            centerPointX /= Index;
            centerPointY /= Index;
            diameter /= Index;
            _currentSketch.SketchCircles.AddByCenterRadius(_transGeometry.CreatePoint2d(centerPointX, centerPointY), 
                0.5 * diameter);
        }

        /// <summary>
        /// Выдавливание положительное.
        /// </summary>
        /// <param name="distance">Длинна выдавливания</param>
        /// <param name="extrudeDirection">Направление выдавливания</param>
        public void ExtrudePositive(double distance, PartFeatureExtentDirectionEnum extrudeDirection = PartFeatureExtentDirectionEnum.kPositiveExtentDirection)
        {
            var extrudeDef = _partDef.Features.ExtrudeFeatures.CreateExtrudeDefinition(_currentSketch.Profiles.AddForSolid(), 
                PartFeatureOperationEnum.kJoinOperation);
            extrudeDef.SetDistanceExtent(distance / Index, extrudeDirection);
            _partDef.Features.ExtrudeFeatures.Add(extrudeDef);
        }

        /// <summary>
        /// Выдавливание отицательное.
        /// </summary>
        /// <param name="distance">Длинна выдавливания</param>
        /// <param name="extrudeDirection">Направление выдавливания</param>
        public void ExtrudeNegative(double distance, PartFeatureExtentDirectionEnum extrudeDirection = PartFeatureExtentDirectionEnum.kNegativeExtentDirection)
        {
            var extrudeDef = _partDef.Features.ExtrudeFeatures.CreateExtrudeDefinition(_currentSketch.Profiles.AddForSolid(),
                PartFeatureOperationEnum.kJoinOperation);
            extrudeDef.SetDistanceExtent(distance / Index, extrudeDirection);
            _partDef.Features.ExtrudeFeatures.Add(extrudeDef);
        }

       
        #endregion

    }
}
