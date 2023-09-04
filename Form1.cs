using System.Collections.Generic;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            List<Person> personList = new List<Person>();

            #region p1
            Person p1 =new Person();
            p1.firstName = "maryam";
            p1.lastName = "mirzakhani";
            p1.nationalIdNumber = "1234567899";
            p1.phoneNumber = "09122274187";
            p1.sex = enumSex.Female;
            personList.Add(p1);
            lblP1.Text="First Name:"+p1.firstName+","+ "Last Name:" + p1.lastName+","+ "National ID:" + p1.nationalIdNumber+","+ "Phone number:" + p1.phoneNumber+","+ "Sex:" + p1.sex;
            //lblTotal.Text=lblP1.Text+Environment.NewLine;   
            #endregion 

            #region p2
            Person p2 = new Person();
            p2.firstName = "sadegh";
            p2.lastName = "hedayat";
            p2.nationalIdNumber = "1234556789";
            p2.phoneNumber = "09133374187";
            p2.sex = enumSex.male;
            personList.Add(p2);
            lblP2.Text = "First Name:" + p2.firstName + "," + "Last Name:" + p2.lastName + "," + "National ID:" + p2.nationalIdNumber + "," + "Phone number:" + p2.phoneNumber + "," + "Sex:" + p2.sex;
            //lblTotal.Text = lblTotal.Text+ lblP2.Text + Environment.NewLine;

            #endregion

            #region p3
            Person p3 = new Person();
            p3.firstName = "sohrab";
            p3.lastName = "sepehri";
            p3.nationalIdNumber = "1567556789";
            p3.phoneNumber = "04133374817";
            p3.sex = enumSex.male;
            personList.Add(p3);
            lblP3.Text = "First Name:" + p3.firstName + "," + "Last Name:" + p3.lastName + "," + "National ID:" + p3.nationalIdNumber + "," + "Phone number:" + p3.phoneNumber + "," + "Sex:" + p3.sex;
            //lblTotal.Text = lblTotal.Text + lblP3.Text + Environment.NewLine;

            #endregion

            #region p4
            Person p4 = new Person();
            p4.firstName = "anoshe";
            p4.lastName = "ansari";
            p4.nationalIdNumber = "1567886789";
            p4.phoneNumber = "04121374817";
            p4.sex = enumSex.Female;
            personList.Add(p4);
            lblP4.Text = "First Name:" + p4.firstName + "," + "Last Name:" + p4.lastName + "," + "National ID:" + p4.nationalIdNumber + "," + "Phone number:" + p4.phoneNumber + "," + "Sex:" + p4.sex;
            //lblTotal.Text = lblTotal.Text + lblP4.Text;

            #endregion

            foreach (Person P in personList)
            {
                lblTotal.Text = lblTotal.Text+ "First Name:" + P.firstName + "," + "Last Name:" + P.lastName + "," + "National ID:" + P.nationalIdNumber + "," + "Phone number:" + P.phoneNumber + "," + "Sex:" + P.sex + Environment.NewLine;
            }
        }

    }
}