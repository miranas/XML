using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vajXml
{
    

        // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
        public partial class vsipodatki
        {

            private vsipodatkiPrevzem[] prevzemField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("prevzem")]
            public vsipodatkiPrevzem[] prevzem
            {
                get
                {
                    return this.prevzemField;
                }
                set
                {
                    this.prevzemField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class vsipodatkiPrevzem
        {

            private vsipodatkiPrevzemClani claniField;

            private ushort letnikField;

            private byte voField;

            private ushort stevilkaField;

            private float kolicinaField;

            private float sladkorField;

            private double vrednostField;

            /// <remarks/>
            public vsipodatkiPrevzemClani clani
            {
                get
                {
                    return this.claniField;
                }
                set
                {
                    this.claniField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public ushort letnik
            {
                get
                {
                    return this.letnikField;
                }
                set
                {
                    this.letnikField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public byte vo
            {
                get
                {
                    return this.voField;
                }
                set
                {
                    this.voField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public ushort stevilka
            {
                get
                {
                    return this.stevilkaField;
                }
                set
                {
                    this.stevilkaField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public float Kolicina
            {
                get
                {
                    return this.kolicinaField;
                }
                set
                {
                    this.kolicinaField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public float sladkor
            {
                get
                {
                    return this.sladkorField;
                }
                set
                {
                    this.sladkorField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public double vrednost
            {
                get
                {
                    return this.vrednostField;
                }
                set
                {
                    this.vrednostField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class vsipodatkiPrevzemClani
        {

            private vsipodatkiPrevzemClaniSorta sortaField;

            private string imeField;

            /// <remarks/>
            public vsipodatkiPrevzemClaniSorta sorta
            {
                get
                {
                    return this.sortaField;
                }
                set
                {
                    this.sortaField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string ime
            {
                get
                {
                    return this.imeField;
                }
                set
                {
                    this.imeField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class vsipodatkiPrevzemClaniSorta
        {

            private string imesField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string imes
            {
                get
                {
                    return this.imesField;
                }
                set
                {
                    this.imesField = value;
                }
            }
        }


    }

