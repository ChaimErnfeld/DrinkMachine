using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.LinkLabel;

namespace DrinkMachine
{
    public partial class Form1 : Form
    {
        XmlDocument xmlDocument = new XmlDocument();
        string pathName = Directory.GetCurrentDirectory() + "\\drinkData.xml";
        public Form1()
        {
            InitializeComponent();
            //בדיקה אם הקובץ קיים
            if (File.Exists(pathName))
            {   //אם כן
                try
                {   //טען את הקובץ
                    xmlDocument.Load(pathName);
                }
                //אם לא הצלחת לטעון הצג הודעת שגיאה מתאימה
                catch (Exception ex)
                {
                    MessageBox.Show("Error loeding XML file: " + ex.Message);
                }
            }
            //אם לא קיים, צור קובץ
            else
            {   
                //יצירת קובץ ראשי חדש
                XmlNode root = xmlDocument.CreateElement("Drinks");

                xmlDocument.AppendChild(root);
                //שמירת הקובץ
                xmlDocument.Save(pathName);
            }
            //קריאה לפונקציה שמציגה את כל הנתונים בגריד וויו
            ShowAllDrinks();
        }

        //public bool CreateDrink(XmlNode root)
        //{
        //    try
        //    {
        //        XmlNode drink = xmlDocument.CreateElement("drink");
        //        XmlNode name = xmlDocument.CreateElement("name");
        //        XmlNode sugar = xmlDocument.CreateElement("sugar");
        //        XmlNode coffee = xmlDocument.CreateElement("coffee");
        //        XmlNode cocoa = xmlDocument.CreateElement("cocoa");
        //        XmlNode milk = xmlDocument.CreateElement("milk");
        //        XmlNode price = xmlDocument.CreateElement("price");


        //        name.InnerText = txtNewDrink.Text;
        //        sugar.InnerText = cmbSugar.Text;
        //        coffee.InnerText  = cmbCoffe.Text;
        //        cocoa.InnerText = cmbCocoa.Text;
        //        milk.InnerText = cmbMilk.Text;
        //        price.InnerText = cmbPrice.Text;

        //        root.AppendChild(drink);
        //        drink.AppendChild(name);
        //        drink.AppendChild(sugar);
        //        drink.AppendChild(coffee);
        //        drink.AppendChild(cocoa);
        //        drink.AppendChild(milk);
        //        drink.AppendChild(price);

        //        //דרך מקוצרת להנ"ל
        //        //drink.AppendChild(xmlDocument.CreateElement("Name")).InnerText = txtNewDrink.Text;
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //}

        

        //פונקציה שבלחיצה על כפתור הוספת נתונים תוסיף נתונים
        private void btnAddDrink_Click(object sender, EventArgs e)
        {
            //יצירת נוד - צומת של דרינק שנמצאת בתוך הקובץ הראשי ותכיל את כל הנתונים 
            XmlNode drink = xmlDocument.CreateElement("drink");

            //הוספת נתונים לתוך הצומת של הדרינק
            drink.AppendChild(xmlDocument.CreateElement("name")).InnerText = txtNewDrink.Text;
            drink.AppendChild(xmlDocument.CreateElement("sugar")).InnerText = cmbSugar.Text;
            drink.AppendChild(xmlDocument.CreateElement("coffee")).InnerText = cmbCoffe.Text;
            drink.AppendChild(xmlDocument.CreateElement("cocoa")).InnerText = cmbCocoa.Text;
            drink.AppendChild(xmlDocument.CreateElement("milk")).InnerText = cmbMilk.Text;
            drink.AppendChild(xmlDocument.CreateElement("price")).InnerText = txtPrice.Text;

            //הגדרת דרינק כילד ראשון של הקובץ הראשי
            xmlDocument.FirstChild.AppendChild(drink);
            MessageBox.Show("הנתונים נוספו בהצלחה! נא שמור את הנתונים");
            //קריאה לפונקציה שמציגה את כל הנתונים בגריד וויו
            ShowAllDrinks();
        }

        //פונקציה שמוחקת את כל הנתונים מהכפתורים ע"י פוראיץ
        private void CleanAllControls()
        {
            //עובר על כל הנתונים שנמצאים בטופס
            foreach (Control ctr in Controls)
            {
                //אם זה מסוג טקסט בוקס או קומבובוקס
                if (ctr is ComboBox || ctr is TextBox)
                {
                    //מנקה את הנתונים
                    ctr.Text = "";
                }
            }
        }

        //פונקציה שבלחיצה על כפתור שמירה תשמור את כל השינויים ע"י סייב בשם הנתיב
        private void btnSave_Click(object sender, EventArgs e)
        {
            xmlDocument.Save(pathName);
            CleanAllControls();
        }

        //פונקציה שבלחיצה על כפתור פלוס תוסיף מספר למחיר
        private void btnPlus_Click(object sender, EventArgs e)
        {
            txtPrice.Text = (double.Parse(txtPrice.Text) + 0.5).ToString();
        }

        //פונקציה שבלחיצה על כפתור מינוס תוריד מספר למחיר
        private void btnMinus_Click(object sender, EventArgs e)
        {
            //מווא שהמחיר לא נמצ על 0
            if (txtPrice.Text != "0")
            {
                  txtPrice.Text = (double.Parse(txtPrice.Text) - 0.5).ToString();
            }
        }

        //פונקציה שמציגה את כל הנתונים בגריד וויו
        private void ShowAllDrinks()
        {
            //דבר ראשון ננקה את כל הנתונים מהגריד וויו
            dgvDrinksTabels.Rows.Clear();
            //נכנס לקובץ הראשי נכנס לילד הראשון ונעבור על כל הצמתים
            foreach (XmlNode drink in xmlDocument.FirstChild.ChildNodes)
            {
                //נגדיר משתני סטרינג על כל הנתונים שיש לנו
                string name = "", sugar = "", coffee = "", cocoa = "", milk = "", price = "";
                //נכנס לכל צומת ונעבור על כל הנתונים שלו
                foreach (XmlNode node in drink.ChildNodes)
                {
                    switch (node.Name)
                    {
                        case "name":
                            name = node.InnerText;
                            break;
                        case "sugar":
                            sugar = node.InnerText;
                            break;
                        case "coffee":
                            coffee = node.InnerText;
                            break;
                        case "cocoa":
                            cocoa = node.InnerText;
                            break;
                        case "milk":
                            milk = node.InnerText;
                            break;
                        case "price":
                            price = node.InnerText;
                            break;

                    }
                }
                //נוסיף לגריד וויו שורה שמכילה את כל הנתונים שמצאנו
                dgvDrinksTabels.Rows.Add(name, sugar, coffee, cocoa, milk, price);
            }
        }

        //פונקציה לעדכון משקה קיים
        private void btnUpdataDrink_Click(object sender, EventArgs e)
        {
            foreach (XmlNode drink in xmlDocument.FirstChild.ChildNodes)
            {
                if (drink.SelectSingleNode("name").InnerText == txtNewDrink.Text)
                {
                    //הצגת הנתונים הקיימים על המשקה שהכנסנו
                    //cmbSugar.Text = drink.SelectSingleNode("sugar").InnerText;
                    //cmbCoffe.Text = drink.SelectSingleNode("coffee").InnerText;
                    //cmbCocoa.Text = drink.SelectSingleNode("cocoa").InnerText;
                    //cmbMilk.Text = drink.SelectSingleNode("milk").InnerText;
                    //txtPrice.Text = drink.SelectSingleNode("price").InnerText;
                    //עדכון הנתונים לנתונים החדשים
                    drink.SelectSingleNode("sugar").InnerText = cmbSugar.Text;
                    drink.SelectSingleNode("coffee").InnerText = cmbCoffe.Text;
                    drink.SelectSingleNode("cocoa").InnerText = cmbCocoa.Text;
                    drink.SelectSingleNode("milk").InnerText = cmbMilk.Text;
                    drink.SelectSingleNode("price").InnerText = txtPrice.Text;
                    //הצגת הנתונים בגריד וויו
                    ShowAllDrinks();
                }
            }
        }

        private void btnDeleteDrink_Click(object sender, EventArgs e)
        {
            foreach (XmlNode drink in xmlDocument.FirstChild.ChildNodes)
            {
                if (drink.SelectSingleNode("name").InnerText == txtNewDrink.Text)
                {
                    xmlDocument.FirstChild.RemoveChild(drink);
                    ShowAllDrinks();
                }
            }
        }

        
    }
}
