using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace WCFWindowsService
{
    public partial class Service1 : ServiceBase
    {
        ServiceHost m_Host;

        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            if (m_Host != null)
            {
                m_Host.Close();
            }

            //Create a URI to serve as the base address
            Uri httpUrl = new Uri("http://localhost:8090/WCFService/SampleClass");

            //Create ServiceHost
            m_Host = new ServiceHost(typeof(WCFService.SampleClass), httpUrl);

            //Add a service endpoint
            m_Host.AddServiceEndpoint(typeof(WCFService.ISampleInterface), new WSHttpBinding(), "");

            //Enable metadata exchange
            ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
            smb.HttpGetEnabled = true;
            m_Host.Description.Behaviors.Add(smb);

            //Start the Service
            m_Host.Open();
        }

        protected override void OnStop()
        {
            if (m_Host != null)
            {
                m_Host.Close();
                m_Host = null;
            }
        }
    }
}
