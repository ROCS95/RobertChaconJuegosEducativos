using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Net.Mail;
using System.Net;

namespace BO
{
    public class CorreoBO
    {
        /// <summary>
        /// envia un correo
        /// </summary>
        /// <param name="correo">Email de donde se quiere enviar el correo</param>
        /// <returns></returns>
        public bool EnviarCorreo(Correo correo)
        {
            if (String.IsNullOrEmpty(correo.From))
            {
                throw new Exception("From es requerido");
            }
            if (String.IsNullOrEmpty(correo.To))
            {
                throw new Exception("To es requerido");
            }
            if (String.IsNullOrEmpty(correo.password))
            {
                throw new Exception("EmailPassword es requerido");
            }
            try
            {
                MailMessage email = new MailMessage();
                email.To.Add(new MailAddress(correo.To));
                email.From = new MailAddress(correo.From);
                email.Subject = "Asunto ( " + DateTime.Now.ToString("dd / MMM / yyy hh:mm:ss") + " ) ";
                email.Body = "<b>y aqui pondria el top 5... Si tuviera uno!</b>";
                email.IsBodyHtml = true;
                email.Priority = MailPriority.Normal;

                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 2525;
                smtp.EnableSsl = false;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential(correo.From, correo.password);

                smtp.Send(email);
                email.Dispose();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
