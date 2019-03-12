using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vajXml
{
    class še_en_račun
    {

        // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
        public partial class AGROMET
        {

            private div divField;

            private string styleField;

            private a aField;

            private AGROMETLocation locationField;

            private AGROMETDATA[] dATAField;

            private span spanField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/1999/xhtml")]
            public div div
            {
                get
                {
                    return this.divField;
                }
                set
                {
                    this.divField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/1999/xhtml")]
            public string style
            {
                get
                {
                    return this.styleField;
                }
                set
                {
                    this.styleField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/1999/xhtml")]
            public a a
            {
                get
                {
                    return this.aField;
                }
                set
                {
                    this.aField = value;
                }
            }

            /// <remarks/>
            public AGROMETLocation Location
            {
                get
                {
                    return this.locationField;
                }
                set
                {
                    this.locationField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("DATA")]
            public AGROMETDATA[] DATA
            {
                get
                {
                    return this.dATAField;
                }
                set
                {
                    this.dATAField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/1999/xhtml")]
            public span span
            {
                get
                {
                    return this.spanField;
                }
                set
                {
                    this.spanField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.w3.org/1999/xhtml", IsNullable = false)]
        public partial class div
        {

            private string styleField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string style
            {
                get
                {
                    return this.styleField;
                }
                set
                {
                    this.styleField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.w3.org/1999/xhtml", IsNullable = false)]
        public partial class a
        {

            private aSpan spanField;

            private string[] textField;

            private sbyte tabindexField;

            private string classField;

            private string roleField;

            private bool ariaexpandedField;

            private byte ariaposinsetField;

            private byte ariasetsizeField;

            private byte arialevelField;

            private string styleField;

            /// <remarks/>
            public aSpan span
            {
                get
                {
                    return this.spanField;
                }
                set
                {
                    this.spanField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string[] Text
            {
                get
                {
                    return this.textField;
                }
                set
                {
                    this.textField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public sbyte tabindex
            {
                get
                {
                    return this.tabindexField;
                }
                set
                {
                    this.tabindexField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string @class
            {
                get
                {
                    return this.classField;
                }
                set
                {
                    this.classField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string role
            {
                get
                {
                    return this.roleField;
                }
                set
                {
                    this.roleField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute("aria-expanded")]
            public bool ariaexpanded
            {
                get
                {
                    return this.ariaexpandedField;
                }
                set
                {
                    this.ariaexpandedField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute("aria-posinset")]
            public byte ariaposinset
            {
                get
                {
                    return this.ariaposinsetField;
                }
                set
                {
                    this.ariaposinsetField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute("aria-setsize")]
            public byte ariasetsize
            {
                get
                {
                    return this.ariasetsizeField;
                }
                set
                {
                    this.ariasetsizeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute("aria-level")]
            public byte arialevel
            {
                get
                {
                    return this.arialevelField;
                }
                set
                {
                    this.arialevelField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string style
            {
                get
                {
                    return this.styleField;
                }
                set
                {
                    this.styleField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
        public partial class aSpan
        {

            private string styleField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string style
            {
                get
                {
                    return this.styleField;
                }
                set
                {
                    this.styleField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class AGROMETLocation
        {

            private a aField;

            private AGROMETLocationLocationID locationIDField;

            private AGROMETLocationLocationName locationNameField;

            private AGROMETLocationLocationAltitude locationAltitudeField;

            private AGROMETLocationLocationDescr locationDescrField;

            private AGROMETLocationTimeFormat timeFormatField;

            private AGROMETLocationURL uRLField;

            private span spanField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/1999/xhtml")]
            public a a
            {
                get
                {
                    return this.aField;
                }
                set
                {
                    this.aField = value;
                }
            }

            /// <remarks/>
            public AGROMETLocationLocationID LocationID
            {
                get
                {
                    return this.locationIDField;
                }
                set
                {
                    this.locationIDField = value;
                }
            }

            /// <remarks/>
            public AGROMETLocationLocationName LocationName
            {
                get
                {
                    return this.locationNameField;
                }
                set
                {
                    this.locationNameField = value;
                }
            }

            /// <remarks/>
            public AGROMETLocationLocationAltitude LocationAltitude
            {
                get
                {
                    return this.locationAltitudeField;
                }
                set
                {
                    this.locationAltitudeField = value;
                }
            }

            /// <remarks/>
            public AGROMETLocationLocationDescr LocationDescr
            {
                get
                {
                    return this.locationDescrField;
                }
                set
                {
                    this.locationDescrField = value;
                }
            }

            /// <remarks/>
            public AGROMETLocationTimeFormat TimeFormat
            {
                get
                {
                    return this.timeFormatField;
                }
                set
                {
                    this.timeFormatField = value;
                }
            }

            /// <remarks/>
            public AGROMETLocationURL URL
            {
                get
                {
                    return this.uRLField;
                }
                set
                {
                    this.uRLField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/1999/xhtml")]
            public span span
            {
                get
                {
                    return this.spanField;
                }
                set
                {
                    this.spanField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class AGROMETLocationLocationID
        {

            private a aField;

            private span spanField;

            private string[] textField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/1999/xhtml")]
            public a a
            {
                get
                {
                    return this.aField;
                }
                set
                {
                    this.aField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/1999/xhtml")]
            public span span
            {
                get
                {
                    return this.spanField;
                }
                set
                {
                    this.spanField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string[] Text
            {
                get
                {
                    return this.textField;
                }
                set
                {
                    this.textField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.w3.org/1999/xhtml", IsNullable = false)]
        public partial class span
        {

            private spanSpan span1Field;

            private string[] textField;

            private string styleField;

            private string classField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("span")]
            public spanSpan span1
            {
                get
                {
                    return this.span1Field;
                }
                set
                {
                    this.span1Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string[] Text
            {
                get
                {
                    return this.textField;
                }
                set
                {
                    this.textField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string style
            {
                get
                {
                    return this.styleField;
                }
                set
                {
                    this.styleField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string @class
            {
                get
                {
                    return this.classField;
                }
                set
                {
                    this.classField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/1999/xhtml")]
        public partial class spanSpan
        {

            private string styleField;

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string style
            {
                get
                {
                    return this.styleField;
                }
                set
                {
                    this.styleField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class AGROMETLocationLocationName
        {

            private a aField;

            private span spanField;

            private string[] textField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/1999/xhtml")]
            public a a
            {
                get
                {
                    return this.aField;
                }
                set
                {
                    this.aField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/1999/xhtml")]
            public span span
            {
                get
                {
                    return this.spanField;
                }
                set
                {
                    this.spanField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string[] Text
            {
                get
                {
                    return this.textField;
                }
                set
                {
                    this.textField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class AGROMETLocationLocationAltitude
        {

            private a aField;

            private span spanField;

            private string[] textField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/1999/xhtml")]
            public a a
            {
                get
                {
                    return this.aField;
                }
                set
                {
                    this.aField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/1999/xhtml")]
            public span span
            {
                get
                {
                    return this.spanField;
                }
                set
                {
                    this.spanField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string[] Text
            {
                get
                {
                    return this.textField;
                }
                set
                {
                    this.textField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class AGROMETLocationLocationDescr
        {

            private a aField;

            private span spanField;

            private string[] textField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/1999/xhtml")]
            public a a
            {
                get
                {
                    return this.aField;
                }
                set
                {
                    this.aField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/1999/xhtml")]
            public span span
            {
                get
                {
                    return this.spanField;
                }
                set
                {
                    this.spanField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string[] Text
            {
                get
                {
                    return this.textField;
                }
                set
                {
                    this.textField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class AGROMETLocationTimeFormat
        {

            private a aField;

            private span spanField;

            private string[] textField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/1999/xhtml")]
            public a a
            {
                get
                {
                    return this.aField;
                }
                set
                {
                    this.aField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/1999/xhtml")]
            public span span
            {
                get
                {
                    return this.spanField;
                }
                set
                {
                    this.spanField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string[] Text
            {
                get
                {
                    return this.textField;
                }
                set
                {
                    this.textField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class AGROMETLocationURL
        {

            private a aField;

            private span spanField;

            private string[] textField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/1999/xhtml")]
            public a a
            {
                get
                {
                    return this.aField;
                }
                set
                {
                    this.aField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/1999/xhtml")]
            public span span
            {
                get
                {
                    return this.spanField;
                }
                set
                {
                    this.spanField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string[] Text
            {
                get
                {
                    return this.textField;
                }
                set
                {
                    this.textField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class AGROMETDATA
        {

            private a aField;

            private AGROMETDATADate dateField;

            private AGROMETDATABATT bATTField;

            private AGROMETDATAMeasurements measurementsField;

            private AGROMETDATATemp2 temp2Field;

            private AGROMETDATATemp2_Min temp2_MinField;

            private AGROMETDATATemp2_Max temp2_MaxField;

            private AGROMETDATAHumidity2 humidity2Field;

            private AGROMETDATAHumidity2_Min humidity2_MinField;

            private AGROMETDATAHumidity2_Max humidity2_MaxField;

            private AGROMETDATALeafwetness2 leafwetness2Field;

            private AGROMETDATALeafwetness2_Min leafwetness2_MinField;

            private AGROMETDATALeafwetness2_Max leafwetness2_MaxField;

            private AGROMETDATAPrecipitation precipitationField;

            private AGROMETDATAPrecipitation_Min precipitation_MinField;

            private AGROMETDATAPrecipitation_Max precipitation_MaxField;

            private span spanField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/1999/xhtml")]
            public a a
            {
                get
                {
                    return this.aField;
                }
                set
                {
                    this.aField = value;
                }
            }

            /// <remarks/>
            public AGROMETDATADate Date
            {
                get
                {
                    return this.dateField;
                }
                set
                {
                    this.dateField = value;
                }
            }

            /// <remarks/>
            public AGROMETDATABATT BATT
            {
                get
                {
                    return this.bATTField;
                }
                set
                {
                    this.bATTField = value;
                }
            }

            /// <remarks/>
            public AGROMETDATAMeasurements Measurements
            {
                get
                {
                    return this.measurementsField;
                }
                set
                {
                    this.measurementsField = value;
                }
            }

            /// <remarks/>
            public AGROMETDATATemp2 Temp2
            {
                get
                {
                    return this.temp2Field;
                }
                set
                {
                    this.temp2Field = value;
                }
            }

            /// <remarks/>
            public AGROMETDATATemp2_Min Temp2_Min
            {
                get
                {
                    return this.temp2_MinField;
                }
                set
                {
                    this.temp2_MinField = value;
                }
            }

            /// <remarks/>
            public AGROMETDATATemp2_Max Temp2_Max
            {
                get
                {
                    return this.temp2_MaxField;
                }
                set
                {
                    this.temp2_MaxField = value;
                }
            }

            /// <remarks/>
            public AGROMETDATAHumidity2 Humidity2
            {
                get
                {
                    return this.humidity2Field;
                }
                set
                {
                    this.humidity2Field = value;
                }
            }

            /// <remarks/>
            public AGROMETDATAHumidity2_Min Humidity2_Min
            {
                get
                {
                    return this.humidity2_MinField;
                }
                set
                {
                    this.humidity2_MinField = value;
                }
            }

            /// <remarks/>
            public AGROMETDATAHumidity2_Max Humidity2_Max
            {
                get
                {
                    return this.humidity2_MaxField;
                }
                set
                {
                    this.humidity2_MaxField = value;
                }
            }

            /// <remarks/>
            public AGROMETDATALeafwetness2 Leafwetness2
            {
                get
                {
                    return this.leafwetness2Field;
                }
                set
                {
                    this.leafwetness2Field = value;
                }
            }

            /// <remarks/>
            public AGROMETDATALeafwetness2_Min Leafwetness2_Min
            {
                get
                {
                    return this.leafwetness2_MinField;
                }
                set
                {
                    this.leafwetness2_MinField = value;
                }
            }

            /// <remarks/>
            public AGROMETDATALeafwetness2_Max Leafwetness2_Max
            {
                get
                {
                    return this.leafwetness2_MaxField;
                }
                set
                {
                    this.leafwetness2_MaxField = value;
                }
            }

            /// <remarks/>
            public AGROMETDATAPrecipitation Precipitation
            {
                get
                {
                    return this.precipitationField;
                }
                set
                {
                    this.precipitationField = value;
                }
            }

            /// <remarks/>
            public AGROMETDATAPrecipitation_Min Precipitation_Min
            {
                get
                {
                    return this.precipitation_MinField;
                }
                set
                {
                    this.precipitation_MinField = value;
                }
            }

            /// <remarks/>
            public AGROMETDATAPrecipitation_Max Precipitation_Max
            {
                get
                {
                    return this.precipitation_MaxField;
                }
                set
                {
                    this.precipitation_MaxField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/1999/xhtml")]
            public span span
            {
                get
                {
                    return this.spanField;
                }
                set
                {
                    this.spanField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class AGROMETDATADate
        {

            private a aField;

            private span spanField;

            private string[] textField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/1999/xhtml")]
            public a a
            {
                get
                {
                    return this.aField;
                }
                set
                {
                    this.aField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/1999/xhtml")]
            public span span
            {
                get
                {
                    return this.spanField;
                }
                set
                {
                    this.spanField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string[] Text
            {
                get
                {
                    return this.textField;
                }
                set
                {
                    this.textField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class AGROMETDATABATT
        {

            private a aField;

            private span spanField;

            private string[] textField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/1999/xhtml")]
            public a a
            {
                get
                {
                    return this.aField;
                }
                set
                {
                    this.aField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/1999/xhtml")]
            public span span
            {
                get
                {
                    return this.spanField;
                }
                set
                {
                    this.spanField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string[] Text
            {
                get
                {
                    return this.textField;
                }
                set
                {
                    this.textField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class AGROMETDATAMeasurements
        {

            private a aField;

            private span spanField;

            private string[] textField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/1999/xhtml")]
            public a a
            {
                get
                {
                    return this.aField;
                }
                set
                {
                    this.aField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/1999/xhtml")]
            public span span
            {
                get
                {
                    return this.spanField;
                }
                set
                {
                    this.spanField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string[] Text
            {
                get
                {
                    return this.textField;
                }
                set
                {
                    this.textField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class AGROMETDATATemp2
        {

            private a aField;

            private span spanField;

            private string[] textField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/1999/xhtml")]
            public a a
            {
                get
                {
                    return this.aField;
                }
                set
                {
                    this.aField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/1999/xhtml")]
            public span span
            {
                get
                {
                    return this.spanField;
                }
                set
                {
                    this.spanField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string[] Text
            {
                get
                {
                    return this.textField;
                }
                set
                {
                    this.textField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class AGROMETDATATemp2_Min
        {

            private a aField;

            private span spanField;

            private string[] textField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/1999/xhtml")]
            public a a
            {
                get
                {
                    return this.aField;
                }
                set
                {
                    this.aField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/1999/xhtml")]
            public span span
            {
                get
                {
                    return this.spanField;
                }
                set
                {
                    this.spanField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string[] Text
            {
                get
                {
                    return this.textField;
                }
                set
                {
                    this.textField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class AGROMETDATATemp2_Max
        {

            private a aField;

            private span spanField;

            private string[] textField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/1999/xhtml")]
            public a a
            {
                get
                {
                    return this.aField;
                }
                set
                {
                    this.aField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/1999/xhtml")]
            public span span
            {
                get
                {
                    return this.spanField;
                }
                set
                {
                    this.spanField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string[] Text
            {
                get
                {
                    return this.textField;
                }
                set
                {
                    this.textField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class AGROMETDATAHumidity2
        {

            private a aField;

            private span spanField;

            private string[] textField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/1999/xhtml")]
            public a a
            {
                get
                {
                    return this.aField;
                }
                set
                {
                    this.aField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/1999/xhtml")]
            public span span
            {
                get
                {
                    return this.spanField;
                }
                set
                {
                    this.spanField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string[] Text
            {
                get
                {
                    return this.textField;
                }
                set
                {
                    this.textField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class AGROMETDATAHumidity2_Min
        {

            private a aField;

            private span spanField;

            private string[] textField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/1999/xhtml")]
            public a a
            {
                get
                {
                    return this.aField;
                }
                set
                {
                    this.aField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/1999/xhtml")]
            public span span
            {
                get
                {
                    return this.spanField;
                }
                set
                {
                    this.spanField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string[] Text
            {
                get
                {
                    return this.textField;
                }
                set
                {
                    this.textField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class AGROMETDATAHumidity2_Max
        {

            private a aField;

            private span spanField;

            private string[] textField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/1999/xhtml")]
            public a a
            {
                get
                {
                    return this.aField;
                }
                set
                {
                    this.aField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/1999/xhtml")]
            public span span
            {
                get
                {
                    return this.spanField;
                }
                set
                {
                    this.spanField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string[] Text
            {
                get
                {
                    return this.textField;
                }
                set
                {
                    this.textField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class AGROMETDATALeafwetness2
        {

            private a aField;

            private span spanField;

            private string[] textField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/1999/xhtml")]
            public a a
            {
                get
                {
                    return this.aField;
                }
                set
                {
                    this.aField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/1999/xhtml")]
            public span span
            {
                get
                {
                    return this.spanField;
                }
                set
                {
                    this.spanField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string[] Text
            {
                get
                {
                    return this.textField;
                }
                set
                {
                    this.textField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class AGROMETDATALeafwetness2_Min
        {

            private a aField;

            private span spanField;

            private string[] textField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/1999/xhtml")]
            public a a
            {
                get
                {
                    return this.aField;
                }
                set
                {
                    this.aField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/1999/xhtml")]
            public span span
            {
                get
                {
                    return this.spanField;
                }
                set
                {
                    this.spanField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string[] Text
            {
                get
                {
                    return this.textField;
                }
                set
                {
                    this.textField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class AGROMETDATALeafwetness2_Max
        {

            private a aField;

            private span spanField;

            private string[] textField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/1999/xhtml")]
            public a a
            {
                get
                {
                    return this.aField;
                }
                set
                {
                    this.aField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/1999/xhtml")]
            public span span
            {
                get
                {
                    return this.spanField;
                }
                set
                {
                    this.spanField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string[] Text
            {
                get
                {
                    return this.textField;
                }
                set
                {
                    this.textField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class AGROMETDATAPrecipitation
        {

            private a aField;

            private span spanField;

            private string[] textField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/1999/xhtml")]
            public a a
            {
                get
                {
                    return this.aField;
                }
                set
                {
                    this.aField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/1999/xhtml")]
            public span span
            {
                get
                {
                    return this.spanField;
                }
                set
                {
                    this.spanField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string[] Text
            {
                get
                {
                    return this.textField;
                }
                set
                {
                    this.textField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class AGROMETDATAPrecipitation_Min
        {

            private a aField;

            private span spanField;

            private string[] textField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/1999/xhtml")]
            public a a
            {
                get
                {
                    return this.aField;
                }
                set
                {
                    this.aField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/1999/xhtml")]
            public span span
            {
                get
                {
                    return this.spanField;
                }
                set
                {
                    this.spanField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string[] Text
            {
                get
                {
                    return this.textField;
                }
                set
                {
                    this.textField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class AGROMETDATAPrecipitation_Max
        {

            private a aField;

            private span spanField;

            private string[] textField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/1999/xhtml")]
            public a a
            {
                get
                {
                    return this.aField;
                }
                set
                {
                    this.aField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/1999/xhtml")]
            public span span
            {
                get
                {
                    return this.spanField;
                }
                set
                {
                    this.spanField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public string[] Text
            {
                get
                {
                    return this.textField;
                }
                set
                {
                    this.textField = value;
                }
            }
        }


    }
}
