using System;
using System.Windows.Forms;

namespace Thermos
{
    /// <summary>
    /// Класс, отвечающий -за внешний вид и функционал формы.
    /// </summary>
    public partial class ThermosForm : Form
    {
        /// <summary>
        /// Параметры модели.
        /// </summary>
        private readonly ThermosProperties _thermosProperties = new ThermosProperties();

        /// <summary>
        /// Модель вала.
        /// </summary>
        private ThermosModel _thermosModel;

        /// <summary>
        /// Интерфейс САПР API.
        /// </summary>
        private InventorApi _inventorApi;
        
        /// <summary>
        /// Инициализация формы.
        /// </summary>
        public ThermosForm()
        {
            InitializeComponent();
            InitParameters();
        }

        
        /// <summary>
        /// Инициализация параметров.
        /// </summary>
        private void InitParameters()
        {
            diameterThermosUpDown1.Parameter = _thermosProperties.GetParameter(ParameterType.ThermosDiameterButtom);
            diameterThermosUpDown2.Parameter = _thermosProperties.GetParameter(ParameterType.ThermosDiameterCelinderExternal);
            diameterThermosUpDown3.Parameter = _thermosProperties.GetParameter(ParameterType.ThermosDiameterCelinderInterior);
            diameterThermosUpDown4.Parameter = _thermosProperties.GetParameter(ParameterType.ThermosDiameterNeck);
            diameterThermosUpDown5.Parameter = _thermosProperties.GetParameter(ParameterType.ThermosDiameterCap);
            lengthThermosUpDown1.Parameter = _thermosProperties.GetParameter(ParameterType.ThermosLengthButtom);
            lengthThermosUpDown2.Parameter = _thermosProperties.GetParameter(ParameterType.ThermosLengthCelinder1);
            lengthThermosUpDown3.Parameter = _thermosProperties.GetParameter(ParameterType.ThermosLengthNeck);
            lengthThermosUpDown4.Parameter = _thermosProperties.GetParameter(ParameterType.ThermosLengthBung);
            parameterUpDown1.Parameter = _thermosProperties.GetParameter(ParameterType.ThermosLengthCap);
         }

        /// <summary>
        /// Построение модели.
        /// </summary>
        /// <param name="sender">Отправитель события</param>
        /// <param name="e">Параметры</param>
        private void BuildVal_Click(object sender, EventArgs e)
        {
            
            {
                _inventorApi = new InventorApi();
                
                _thermosModel = new ThermosModel(_thermosProperties, _inventorApi);
                _thermosModel.Build(); 
            }
        }
        
    }
}
