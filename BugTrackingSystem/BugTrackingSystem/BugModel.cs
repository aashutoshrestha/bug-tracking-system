using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTrackingSystem
{
    class BugModel
    {
        
        String summary,version, severity, os, classname, method,  vcurl, bugdesc,code;
        int component_id, linenofrom, linenoto;
        String imglocation;
        int bug_id;
        String status;
       System.Drawing.Image screenshot;

        public void setImageLocation(String imagelocation) {
            this.imglocation = imagelocation;
        }

        public String getImageLocation()
        {
            return imglocation;
        }




        public void setImage(System.Drawing.Image img) {
            this.screenshot = img;
        }
   

        public System.Drawing.Image GetImage()
        {
            return screenshot;
        }

        public void setStatus(String status)
        {
            this.status = status;
        }

        public String getStatus()
        {
            return status;
        }

        public void setBugID(int bugid)
        {
            this.bug_id = bugid;
        }

        public int getBUGID()
        {
            return bug_id;
        }
      

        public void setCode(String code)
        {
            this.code = code;
        }

        public String getCode()
        {
            return code;
        }

        public void setVersion(String version)
        {
            this.version = version;
        }

        public String getVersion()
        {
            return version;
        }
        public void setSummary(String summary)
        {
            this.summary = summary;
        }
        public String getSummary()
        {
            return summary;
        }

        public void setSeverity(String severity)
        {
            this.severity = severity;
        }
        public String getSeverity()
        {
            return severity;
        }


        public void setOS(String os)
        {
            this.os = os;
        }
        public String getOS()
        {
            return os;
        }


        public void setClass(String classname)
        {
            this.classname = classname;
        }
        public String getClass()
        {
            return classname;
        }

        public void setMethod(String method)
        {
            this.method = method;
        }
        public String getMethod()
        {
            return method;
        }


        public void setVCURL(String vcurl)
        {
            this.vcurl = vcurl;
        }
        public String getVCURL()
        {
            return vcurl;
        }

        public void setbugdesc(String bugdesc)
        {
            this.bugdesc = bugdesc;
        }
        public String getbugdesc()
        {
            return bugdesc;
        }


        public void setComponentID(int componentid)
        {
            this.component_id = componentid;
        }
        public int getComponentID()
        {
            return component_id;
        }

        public void setlinenofrom(int linenofrom)
        {
            this.linenofrom = linenofrom;
        }
        public int getlinenofrom()
        {
            return linenofrom;
        }

        public void setlinenoto(int linenoto)
        {
            this.linenoto = linenoto;
        }
        public int getlinenoto()
        {
            return linenoto;
        }


    }
}
