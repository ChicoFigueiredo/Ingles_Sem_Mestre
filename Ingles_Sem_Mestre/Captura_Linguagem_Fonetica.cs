using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ingles_Sem_Mestre;
using System.Text.RegularExpressions;
using System.Net;

namespace Ingles_Sem_Mestre
{
    class Captura_Linguagem_Fonetica
    {
        private WebClientX web = new WebClientX();
        private String _last_navigation="";
        const String site = "http://www.photransedit.com/online/txt2phntx.aspx";
        const String site_req = "tcl=316394&bgc=FFFFFF&lng=bre&spc=true&rst=false&pun=false&syc=true&rcr=false&inr=true&syl=false&__EVENTARGUMENT=&__EVENTTARGET=btnTranscribe&__EVENTVALIDATION=%2FwEdAAQREMFE2%2F%2BJdv64hYD98ltS2ZB4LJGZAp%2FMBUq2VBryxv0vaKvO1BnI1DUg5W0LnI%2FrwKGo37IthiH6twnFYW2wozrA7pbbomdYS%2BjMZDE89Bf0vMPxOPcKS%2FELPul0MpE%3D&__VIEWSTATE=%2FwEPDwUJMjQwNjM4Njk1D2QWAgIBDxYCHgdiZ2NvbG9yBQcjRkZGRkZGFgICAQ9kFhYCAQ8PFgIeB1Zpc2libGVoZGQCAw8PFgYeBFRleHQFElRleHQgdG8gUGhvbmV0aWNzOh4JRm9yZUNvbG9yCZRjMf8eBF8hU0ICBGRkAgUPD2QWBB4Kb25rZXlwcmVzcwUeIFZhbGlkYXJDYXJhY3RlcmVzKHRoaXMsIDMwMCk7HgdvbmtleXVwBR4gVmFsaWRhckNhcmFjdGVyZXModGhpcywgMzAwKTtkAgcPEA8WAh4HQ2hlY2tlZGdkZGRkAg8PEA8WBB8CBQtzcGFjZXMgdHJ1ZR8HZ2RkZGQCEQ8QDxYCHwdoZGRkZAITDxAPFgIfB2hkZGRkAhUPEA8WAh8HZ2RkZGQCFw8QDxYCHwdoZGRkZAIZDxAPFgIfB2dkZGRkAhsPEA8WAh8HaGRkZGRkiNBSc4GRLDIA9O7zXPGJ7CcILNFRTVey0wqA7yZAZtg%3D&__VIEWSTATEGENERATOR=8BD6E665&tlt=Teste&txtText=";
        
        public Captura_Linguagem_Fonetica()
        {
            web.Encoding = Encoding.UTF8;
            _last_navigation = web.DownloadString("http://upodn.com/");
        }

        public string Get_Fonetico(string texto_a_fonetizar)
        {
            //Regex R = new Regex("[<]textarea name=\"txtTranscription\".*?[|](.*?)[|]",RegexOptions.Multiline);
            Regex R = new Regex("[|](.{1,})[|]", RegexOptions.Multiline);
            string param = site_req + Uri.EscapeUriString(texto_a_fonetizar);
            _last_navigation = web.DownloadString(site + "?" + param);//.UploadString(site, "POST", param );

            String response = WebUtility.HtmlDecode(R.Matches(_last_navigation)[0].Groups[1].Value.Trim());
            
            return response;
        }
    }
}
