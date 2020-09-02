using System;
using System.Collections;

namespace myData_ns
{
    class myData
    {
        public string group;
        public string series;
        public string type;
        public string uri;

        public ArrayList series_list;
        public ArrayList type_list;

        public void updateGroup(string input)
        {
            this.group = input;
            series_list = new ArrayList();
            fillSeriesList();
        }
        public void updateSeries()
        {
            type_list = new ArrayList();
            fillTypeList();
        }

        private void fillSeriesList()
        {
            switch (this.group)
            {
                case "High":
                    this.series_list.Add("F2");
                    this.series_list.Add("F4");
                    this.series_list.Add("F7");
                    this.series_list.Add("H7");
                    break;
                case "Main":
                    this.series_list.Add("F0");
                    this.series_list.Add("F1");
                    this.series_list.Add("F3");
                    this.series_list.Add("G0");
                    this.series_list.Add("G4");
                    break;
                case "Ultra":
                    this.series_list.Add("L0");
                    this.series_list.Add("L1");
                    this.series_list.Add("L4");
                    this.series_list.Add("L4+");
                    this.series_list.Add("L5");
                    break;
            }
        }
        private void fillTypeList()
        {
            switch (this.series)
            {
                case "F2":
                    this.type_list.Add("F2x5");
                    this.type_list.Add("F2x7");
                    break;
                case "F4":
                    this.type_list.Add("F401");
                    this.type_list.Add("F405-415");
                    this.type_list.Add("F407-417");
                    this.type_list.Add("F410");
                    this.type_list.Add("F411");
                    this.type_list.Add("F412");
                    this.type_list.Add("F413-423");
                    this.type_list.Add("F427-437");
                    this.type_list.Add("F429-439");
                    this.type_list.Add("F446");
                    this.type_list.Add("F469-479");
                    break;
                case "F7":
                    this.type_list.Add("F7x2");
                    this.type_list.Add("F7x3");
                    this.type_list.Add("F7x5");
                    this.type_list.Add("F7x6");
                    this.type_list.Add("F7x7");
                    this.type_list.Add("F7x9");
                    break;
                case "H7":
                    this.type_list.Add("H742");
                    this.type_list.Add("H743-753");
                    this.type_list.Add("H745-755");
                    this.type_list.Add("H747-757");
                    this.type_list.Add("H7A3-7B3");
                    break;
                case "F0":
                    this.type_list.Add("F0x0");
                    this.type_list.Add("F0x1");
                    this.type_list.Add("F0x2");
                    this.type_list.Add("F0x8");
                    break;
                case "F1":
                    this.type_list.Add("Fx101");
                    this.type_list.Add("Fx102");
                    this.type_list.Add("Fx103");
                    this.type_list.Add("Fx105-107");
                    break;
                case "F3":
                    this.type_list.Add("F301");
                    this.type_list.Add("F302");
                    this.type_list.Add("F303");
                    this.type_list.Add("F334");
                    this.type_list.Add("F373");
                    this.type_list.Add("F3x8");
                    break;
                case "G0":
                    this.type_list.Add("G0x1");
                    break;
                case "G4":
                    this.type_list.Add("G4x1");
                    this.type_list.Add("G4x3");
                    this.type_list.Add("G4x4");
                    break;
                case "L0":
                    this.type_list.Add("L0x1");
                    this.type_list.Add("L0x2");
                    this.type_list.Add("L0x3");
                    break;
                case "L1":
                    this.type_list.Add("L151-152");
                    this.type_list.Add("L162");
                    break;
                case "L4":
                    this.type_list.Add("L4x1");
                    this.type_list.Add("L4x2");
                    this.type_list.Add("L4x3");
                    this.type_list.Add("L4x5");
                    this.type_list.Add("L4x6");
                    break;
                case "L4+":
                    this.type_list.Add("L4p5-q5");
                    this.type_list.Add("L4r5-s5");
                    this.type_list.Add("L4r7-s7");
                    this.type_list.Add("L4r9-s9");
                    break;
                case "L5":
                    this.type_list.Add("L5x2");
                    break;
            }
        }

        public void getSeriesUrl()
        {
            string series = this.series.ToLower();
            this.uri = string.Format("https://www.st.com/en/microcontrollers-microprocessors/stm32{0}-series.html", series);
        }
        public void getTypeUrl()
        {
            string type = this.type.ToLower();
            this.uri = string.Format("https://www.st.com/en/microcontrollers-microprocessors/stm32{0}.html", type);
        }
    }

}
