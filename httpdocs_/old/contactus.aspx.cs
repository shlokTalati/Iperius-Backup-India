using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Net.Mail;

public partial class contactus : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            Response.Output.WriteLine("Sending mail");
            SendMail();
            lblMsgSend.Text = "Your request has been sent successfully.";
            lblMsgSend.Visible = true;
            txtOggetto.Text = "";
            txtEmail.Text = "";
            txtMessaggio.Text = "";
            txtNome.Text = "";
            cbxMotivo.Value = "";
        }
        catch (Exception ex)
        {
            Response.Output.WriteLine(ex.Message);
            Response.End();
        }
    }

    protected void SendMail()
    {
        string fromAddress = "inquiryform@niftysolution.com";// Gmail Address from where you send the mail
        string toAddress = "support@niftysolutions.co.in";
        const string fromPassword = "inq##123";//Password of your gmail address
        string mail_subject = "Iperius contact email response";
        string body = emailbody.Replace("#contactreason#", cbxMotivo.Value);
        body = body.Replace("#name#", txtNome.Text);
        body = body.Replace("#email#", txtEmail.Text);
        body = body.Replace("#subject#", txtOggetto.Text);
        body = body.Replace("#message#", txtMessaggio.Text);

        var msg = new MailMessage(fromAddress,toAddress, mail_subject, body);

        msg.IsBodyHtml = true;

        var smtp = new System.Net.Mail.SmtpClient();
        {
            smtp.Host = "mail.niftysolution.com";
            smtp.Port = 587;
            smtp.EnableSsl = false;
            smtp.UseDefaultCredentials = false;
            //smtp.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(fromAddress, fromPassword);
            smtp.Timeout = 20000;
        }
       
        //smtp.Send(fromAddress, toAddress, mail_subject, body);
        smtp.Send(msg);
    }

    public string emailbody = @"
<!DOCTYPE html>
<html lang='en' xmlns:o='urn:schemas-microsoft-com:office:office' xmlns:v='urn:schemas-microsoft-com:vml'>
<head>
    <title></title>
    <meta content='text/html; charset=utf-8' http-equiv='Content-Type' />
    <meta content='width=device-width,initial-scale=1' name='viewport' /><!--[if mso]><xml><o:OfficeDocumentSettings><o:PixelsPerInch>96</o:PixelsPerInch><o:AllowPNG/></o:OfficeDocumentSettings></xml><![endif]-->
    <style>
        * {
            box-sizing: border-box
        }

        body {
            margin: 0;
            padding: 0
        }

        a[x-apple-data-detectors] {
            color: inherit !important;
            text-decoration: inherit !important
        }

        #MessageViewBody a {
            color: inherit;
            text-decoration: none
        }

        p {
            line-height: inherit
        }

        .desktop_hide, .desktop_hide table {
            mso-hide: all;
            display: none;
            max-height: 0;
            overflow: hidden
        }

        @media (max-width:660px) {
            .desktop_hide table.icons-inner {
                display: inline-block !important
            }

            .icons-inner {
                text-align: center
            }

                .icons-inner td {
                    margin: 0 auto
                }

            .row-content {
                width: 100% !important
            }

            .mobile_hide {
                display: none
            }

            .stack .column {
                width: 100%;
                display: block
            }

            .mobile_hide {
                min-height: 0;
                max-height: 0;
                max-width: 0;
                overflow: hidden;
                font-size: 0
            }

            .desktop_hide, .desktop_hide table {
                display: table !important;
                max-height: none !important
            }
        }
    </style>
</head>
<body style='background-color:#f6f8f8;margin:0;padding:0;-webkit-text-size-adjust:none;text-size-adjust:none'>
    <table border='0' cellpadding='0' cellspacing='0' class='nl-container' role='presentation' style='mso-table-lspace:0;mso-table-rspace:0;background-color:#f6f8f8' width='100%'>
        <tbody>
            <tr>
                <td>
                    <table align='center' border='0' cellpadding='0' cellspacing='0' class='row row-1' role='presentation' style='mso-table-lspace:0;mso-table-rspace:0;background-color:#2b3940' width='100%'>
                        <tbody>
                            <tr>
                                <td>
                                    <table align='center' border='0' cellpadding='0' cellspacing='0' class='row-content' role='presentation' style='mso-table-lspace:0;mso-table-rspace:0;color:#000;width:640px' width='640'>
                                        <tbody>
                                            <tr>
                                                <td class='column column-1' style='mso-table-lspace:0;mso-table-rspace:0;font-weight:400;text-align:left;vertical-align:top;border-top:0;border-right:0;border-bottom:0;border-left:0' width='50%'>
                                                    <table border='0' cellpadding='0' cellspacing='0' class='image_block block-2' role='presentation' style='mso-table-lspace:0;mso-table-rspace:0' width='100%'>
                                                        <tr><td class='pad' style='padding-left:20px;padding-top:15px;width:100%;padding-right:0;padding-bottom:5px'><div align='left' class='alignment' style='line-height:10px'><img src='http://www.iperiusbackup.in/img/logos/logo.png' style='display:block;height:auto;border:0;width:126px;max-width:100%' width='126' /></div></td></tr>
                                                    </table>
                                                </td>
                                                <td class='column column-2' style='mso-table-lspace:0;mso-table-rspace:0;font-weight:400;text-align:left;vertical-align:top;border-top:0;border-right:0;border-bottom:0;border-left:0' width='50%'><table border='0' cellpadding='0' cellspacing='0' class='text_block block-2' role='presentation' style='mso-table-lspace:0;mso-table-rspace:0;word-break:break-word' width='100%'><tr><td class='pad' style='padding-bottom:20px;padding-right:20px;padding-top:20px'><div style='font-family:sans-serif'><div class='txtTinyMce-wrapper' style='font-size:12px;font-family:Montserrat,Trebuchet MS,Lucida Grande,Lucida Sans Unicode,Lucida Sans,Tahoma,sans-serif;mso-line-height-alt:14.399999999999999px;color:#555;line-height:1.2'><p style='margin:0;font-size:14px;text-align:right'><span style='font-size:13px;color:#8c9497;'>support@niftysolutions.co.in</span></p></div></div></td></tr></table></td>
                                            </tr>
                                        </tbody>
                                    </table>
                                </td>
                            </tr>
                        </tbody>
                    </table><table align='center' border='0' cellpadding='0' cellspacing='0' class='row row-2' role='presentation' style='mso-table-lspace:0;mso-table-rspace:0;background-color:#2b3940' width='100%'><tbody><tr><td><table align='center' border='0' cellpadding='0' cellspacing='0' class='row-content stack' role='presentation' style='mso-table-lspace:0;mso-table-rspace:0;color:#000;width:640px' width='640'><tbody><tr><td class='column column-1' style='mso-table-lspace:0;mso-table-rspace:0;font-weight:400;text-align:left;vertical-align:top;padding-top:0;padding-bottom:0;border-top:0;border-right:0;border-bottom:0;border-left:0' width='100%'><table border='0' cellpadding='0' cellspacing='0' class='divider_block block-1' role='presentation' style='mso-table-lspace:0;mso-table-rspace:0' width='100%'><tr><td class='pad' style='padding-left:20px;padding-right:20px'><div align='center' class='alignment'><table border='0' cellpadding='0' cellspacing='0' role='presentation' style='mso-table-lspace:0;mso-table-rspace:0' width='100%'><tr><td class='divider_inner' style='font-size:1px;line-height:1px;border-top:1px solid #404d53'><span> </span></td></tr></table></div></td></tr></table></td></tr></tbody></table></td></tr></tbody></table><table align='center' border='0' cellpadding='0' cellspacing='0' class='row row-3' role='presentation' style='mso-table-lspace:0;mso-table-rspace:0' width='100%'>
                        <tbody>
                            <tr>
                                <td>
                                    <table align='center' border='0' cellpadding='0' cellspacing='0' class='row-content stack' role='presentation' style='mso-table-lspace:0;mso-table-rspace:0;color:#000;width:640px' width='640'>
                                        <tbody>
                                            <tr>
                                                <td class='column column-1' style='mso-table-lspace:0;mso-table-rspace:0;font-weight:400;text-align:left;vertical-align:top;padding-top:0;padding-bottom:0;border-top:0;border-right:0;border-bottom:0;border-left:0' width='100%'>
                                                    <table border='0' cellpadding='0' cellspacing='0' class='text_block block-2' role='presentation' style='mso-table-lspace:0;mso-table-rspace:0;word-break:break-word' width='100%'>
                                                        <tr>
                                                            <td class='pad' style='padding-bottom:15px;padding-left:30px;padding-right:30px;padding-top:30px'>
                                                                <div style='font-family:sans-serif'>
                                                                    <div class='txtTinyMce-wrapper' style='font-size:14px;mso-line-height-alt:16.8px;color:#555;line-height:1.2;font-family:Montserrat,Trebuchet MS,Lucida Grande,Lucida Sans Unicode,Lucida Sans,Tahoma,sans-serif'>
                                                                        <p style='margin:0;font-size:14px;text-align:center'>
                                                                            <span style='font-size:30px;color:#2b3940;'><strong><span style=''>New Contact Inquiry </span></strong></span>
                                                                        </p>
                                                                    </div>
                                                                </div>
                                                            </td>
                                                        </tr>
                                                    </table><table border='0' cellpadding='0' cellspacing='0' class='text_block block-3' role='presentation' style='mso-table-lspace:0;mso-table-rspace:0;word-break:break-word' width='100%'><tr><td class='pad' style='padding-bottom:23px;padding-left:20px;padding-right:20px;padding-top:5px'><div style='font-family:sans-serif'><div class='txtTinyMce-wrapper' style='font-size:14px;mso-line-height-alt:21px;color:#555;line-height:1.5;font-family:Montserrat,Trebuchet MS,Lucida Grande,Lucida Sans Unicode,Lucida Sans,Tahoma,sans-serif'><p style='margin:0;font-size:14px;text-align:center'><span style='color:#7e8989;'>
                                                    New inquiry get from #email#.</span></p></div></div></td></tr></table>
                                                </td>
                                            </tr>
                                        </tbody>
                                    </table>
                                </td>
                            </tr>
                        </tbody>
                    </table><table align='center' border='0' cellpadding='0' cellspacing='0' class='row row-4' role='presentation' style='mso-table-lspace:0;mso-table-rspace:0' width='100%'>
                        <tbody>
                            <tr>
                                <td>
                                    <table align='center' border='0' cellpadding='0' cellspacing='0' class='row-content stack' role='presentation' style='mso-table-lspace:0;mso-table-rspace:0;background-color:#fff;color:#000;width:640px' width='640'>
                                        <tbody>
                                            <tr>
                                                <td class='column column-1' style='mso-table-lspace:0;mso-table-rspace:0;font-weight:400;text-align:left;vertical-align:top;padding-top:0;padding-bottom:0;border-top:0;border-right:0;border-bottom:0;border-left:0' width='100%'>
                                                    <table border='0' cellpadding='0' cellspacing='0' class='text_block block-1' role='presentation' style='mso-table-lspace:0;mso-table-rspace:0;word-break:break-word' width='100%'>
                                                        <tr>
                                                            <td class='pad' style='padding-bottom:10px;padding-left:40px;padding-right:40px;padding-top:20px'>
                                                                <div style='font-family:sans-serif'>
                                                                    <div class='txtTinyMce-wrapper' style='font-size:14px;mso-line-height-alt:21px;color:#555;line-height:1.5;font-family:Montserrat,Trebuchet MS,Lucida Grande,Lucida Sans Unicode,Lucida Sans,Tahoma,sans-serif'>
                                                                        <p style='margin:0;font-size:14px'>
                                                                            <strong>
                                                                                <span style='color:#7e8989;font-size:12px;'>
                                                                                    Contact reason
                                                                                </span>
                                                                            </strong>
                                                                        </p><p style='margin:0;font-size:14px;mso-line-height-alt:24px'>
                                                                            <span style='font-size:16px;color:#2b3940;'>
                                                                                <strong>
                                                                                    <span style=''>
                                                                                        #contactreason#
                                                                                    </span>
                                                                                </strong>
                                                                            </span>
                                                                        </p>
                                                                    </div>
                                                                </div>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                    
                                                    <table border='0' cellpadding='0' cellspacing='0' class='divider_block block-4' role='presentation' style='mso-table-lspace:0;mso-table-rspace:0' width='100%'><tr><td class='pad' style='padding-bottom:10px;padding-left:40px;padding-right:40px;padding-top:10px'><div align='center' class='alignment'><table border='0' cellpadding='0' cellspacing='0' role='presentation' style='mso-table-lspace:0;mso-table-rspace:0' width='100%'><tr><td class='divider_inner' style='font-size:1px;line-height:1px;border-top:1px solid #e9ebeb'><span> </span></td></tr></table></div></td></tr></table>

                                                    <table border='0' cellpadding='0' cellspacing='0' class='text_block block-5' role='presentation' style='mso-table-lspace:0;mso-table-rspace:0;word-break:break-word' width='100%'>
                                                        <tr>
                                                            <td class='pad' style='padding-bottom:10px;padding-left:40px;padding-right:40px;padding-top:10px'>
                                                                <div style='font-family:sans-serif'>
                                                                    <div class='txtTinyMce-wrapper' style='font-size:14px;mso-line-height-alt:21px;color:#555;line-height:1.5;font-family:Montserrat,Trebuchet MS,Lucida Grande,Lucida Sans Unicode,Lucida Sans,Tahoma,sans-serif'>
                                                                        <p style='margin:0;font-size:14px'><strong><span style='color:#7e8989;font-size:12px;'>Name</span></strong></p><p style='margin:0;font-size:14px;mso-line-height-alt:24px'>
                                                                            <span style='font-size:16px;color:#2b3940;'>
                                                                                <strong>
                                                                                    <span style=''>
                                                                                        #name#
                                                                                    </span>
                                                                                </strong>
                                                                            </span>
                                                                        </p>
                                                                    </div>
                                                                </div>
                                                            </td>
                                                        </tr>
                                                    </table><table border='0' cellpadding='0' cellspacing='0' class='divider_block block-6' role='presentation' style='mso-table-lspace:0;mso-table-rspace:0' width='100%'><tr><td class='pad' style='padding-bottom:10px;padding-left:40px;padding-right:40px;padding-top:10px'><div align='center' class='alignment'><table border='0' cellpadding='0' cellspacing='0' role='presentation' style='mso-table-lspace:0;mso-table-rspace:0' width='100%'><tr><td class='divider_inner' style='font-size:1px;line-height:1px;border-top:1px solid #e9ebeb'><span> </span></td></tr></table></div></td></tr></table>

                                                    <table border='0' cellpadding='0' cellspacing='0' class='text_block block-3' role='presentation' style='mso-table-lspace:0;mso-table-rspace:0;word-break:break-word' width='100%'>
                                                        <tr>
                                                            <td class='pad' style='padding-bottom:10px;padding-left:40px;padding-right:40px;padding-top:10px'>
                                                                <div style='font-family:sans-serif'>
                                                                    <div class='txtTinyMce-wrapper' style='font-size:14px;mso-line-height-alt:21px;color:#555;line-height:1.5;font-family:Montserrat,Trebuchet MS,Lucida Grande,Lucida Sans Unicode,Lucida Sans,Tahoma,sans-serif'>
                                                                        <p style='margin:0;font-size:14px'>
                                                                            <strong>
                                                                                <span style='color:#7e8989;font-size:12px;'>
                                                                                    Email
                                                                                </span>
                                                                            </strong>
                                                                        </p><p style='margin:0;font-size:14px;mso-line-height-alt:24px'>
                                                                            <span style='font-size:16px;color:#2b3940;'><strong><span style=''>#email#</span></strong></span>
                                                                        </p>
                                                                    </div>
                                                                </div>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                    <table border='0' cellpadding='0' cellspacing='0' class='divider_block block-4' role='presentation' style='mso-table-lspace:0;mso-table-rspace:0' width='100%'><tr><td class='pad' style='padding-bottom:10px;padding-left:40px;padding-right:40px;padding-top:10px'><div align='center' class='alignment'><table border='0' cellpadding='0' cellspacing='0' role='presentation' style='mso-table-lspace:0;mso-table-rspace:0' width='100%'><tr><td class='divider_inner' style='font-size:1px;line-height:1px;border-top:1px solid #e9ebeb'><span> </span></td></tr></table></div></td></tr></table>


                                                    <table border='0' cellpadding='0' cellspacing='0' class='text_block block-3' role='presentation' style='mso-table-lspace:0;mso-table-rspace:0;word-break:break-word' width='100%'>
                                                        <tr>
                                                            <td class='pad' style='padding-bottom:10px;padding-left:40px;padding-right:40px;padding-top:10px'>
                                                                <div style='font-family:sans-serif'>
                                                                    <div class='txtTinyMce-wrapper' style='font-size:14px;mso-line-height-alt:21px;color:#555;line-height:1.5;font-family:Montserrat,Trebuchet MS,Lucida Grande,Lucida Sans Unicode,Lucida Sans,Tahoma,sans-serif'>
                                                                        <p style='margin:0;font-size:14px'>
                                                                            <strong>
                                                                                <span style='color:#7e8989;font-size:12px;'>
                                                                                    Subject
                                                                                </span>
                                                                            </strong>
                                                                        </p><p style='margin:0;font-size:14px;mso-line-height-alt:24px'>
                                                                            <span style='font-size:16px;color:#2b3940;'><strong><span style=''>#subject#</span></strong></span>
                                                                        </p>
                                                                    </div>
                                                                </div>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                    <table border='0' cellpadding='0' cellspacing='0' class='divider_block block-4' role='presentation' style='mso-table-lspace:0;mso-table-rspace:0' width='100%'><tr><td class='pad' style='padding-bottom:10px;padding-left:40px;padding-right:40px;padding-top:10px'><div align='center' class='alignment'><table border='0' cellpadding='0' cellspacing='0' role='presentation' style='mso-table-lspace:0;mso-table-rspace:0' width='100%'><tr><td class='divider_inner' style='font-size:1px;line-height:1px;border-top:1px solid #e9ebeb'><span> </span></td></tr></table></div></td></tr></table>

                                                    <table border='0' cellpadding='0' cellspacing='0' class='text_block block-3' role='presentation' style='mso-table-lspace:0;mso-table-rspace:0;word-break:break-word' width='100%'>
                                                        <tr>
                                                            <td class='pad' style='padding-bottom:10px;padding-left:40px;padding-right:40px;padding-top:10px'>
                                                                <div style='font-family:sans-serif'>
                                                                    <div class='txtTinyMce-wrapper' style='font-size:14px;mso-line-height-alt:21px;color:#555;line-height:1.5;font-family:Montserrat,Trebuchet MS,Lucida Grande,Lucida Sans Unicode,Lucida Sans,Tahoma,sans-serif'>
                                                                        <p style='margin:0;font-size:14px'>
                                                                            <strong>
                                                                                <span style='color:#7e8989;font-size:12px;'>
                                                                                    Message
                                                                                </span>
                                                                            </strong>
                                                                        </p><p style='margin:0;font-size:14px;mso-line-height-alt:24px'>
                                                                            <span style='font-size:16px;color:#2b3940;'><strong><span style=''>#message#</span></strong></span>
                                                                        </p>
                                                                    </div>
                                                                </div>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                    <table border='0' cellpadding='0' cellspacing='0' class='divider_block block-4' role='presentation' style='mso-table-lspace:0;mso-table-rspace:0' width='100%'><tr><td class='pad' style='padding-bottom:10px;padding-left:40px;padding-right:40px;padding-top:10px'><div align='center' class='alignment'><table border='0' cellpadding='0' cellspacing='0' role='presentation' style='mso-table-lspace:0;mso-table-rspace:0' width='100%'><tr><td class='divider_inner' style='font-size:1px;line-height:1px;border-top:1px solid #e9ebeb'><span> </span></td></tr></table></div></td></tr></table>

                                                </td>
                                            </tr>
                                        </tbody>
                                    </table>
                                </td>
                            </tr>
                        </tbody>
                    </table><table align='center' border='0' cellpadding='0' cellspacing='0' class='row row-5' role='presentation' style='mso-table-lspace:0;mso-table-rspace:0' width='100%'>
                        <tbody>
                            <tr>
                                <td>
                                    <table align='center' border='0' cellpadding='0' cellspacing='0' class='row-content stack' role='presentation' style='mso-table-lspace:0;mso-table-rspace:0;background-color:#fff;color:#000;width:640px' width='640'>
                                        <tbody>
                                            <tr>
                                                <td class='column column-1' style='mso-table-lspace:0;mso-table-rspace:0;font-weight:400;text-align:left;vertical-align:top;padding-top:0;padding-bottom:0;border-top:0;border-right:0;border-bottom:0;border-left:0' width='100%'>
                                                    <table border='0' cellpadding='0' cellspacing='0' class='divider_block block-1' role='presentation' style='mso-table-lspace:0;mso-table-rspace:0' width='100%'>
                                                        <tr>
                                                            <td class='pad' style='padding-bottom:10px;padding-left:40px;padding-right:40px;padding-top:10px'>
                                                                <div align='center' class='alignment'>
                                                                    <table border='0' cellpadding='0' cellspacing='0' role='presentation' style='mso-table-lspace:0;mso-table-rspace:0' width='100%'>
                                                                       
                                                                    </table>
                                                                </div>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </td>
                                            </tr>
                                        </tbody>
                                    </table>
                                </td>
                            </tr>
                        </tbody>
                    </table> 
                    <table align='center' border='0' cellpadding='0' cellspacing='0' class='row row-8' role='presentation' style='mso-table-lspace:0;mso-table-rspace:0' width='100%'><tbody><tr><td><table align='center' border='0' cellpadding='0' cellspacing='0' class='row-content stack' role='presentation' style='mso-table-lspace:0;mso-table-rspace:0;color:#000;width:640px' width='640'><tbody><tr><td class='column column-1' style='mso-table-lspace:0;mso-table-rspace:0;font-weight:400;text-align:left;vertical-align:top;padding-top:0;padding-bottom:0;border-top:0;border-right:0;border-bottom:0;border-left:0' width='100%'><table border='0' cellpadding='0' cellspacing='0' class='empty_block block-1' role='presentation' style='mso-table-lspace:0;mso-table-rspace:0' width='100%'><tr><td class='pad'><div></div></td></tr></table></td></tr></tbody></table></td></tr></tbody></table><table align='center' border='0' cellpadding='0' cellspacing='0' class='row row-9' role='presentation' style='mso-table-lspace:0;mso-table-rspace:0' width='100%'><tbody><tr><td><table align='center' border='0' cellpadding='0' cellspacing='0' class='row-content stack' role='presentation' style='mso-table-lspace:0;mso-table-rspace:0;color:#000;width:640px' width='640'><tbody><tr><td class='column column-1' style='mso-table-lspace:0;mso-table-rspace:0;font-weight:400;text-align:left;vertical-align:top;padding-top:0;padding-bottom:0;border-top:0;border-right:0;border-bottom:0;border-left:0' width='100%'><div class='spacer_block' style='height:70px;line-height:70px;font-size:1px'> </div></td></tr></tbody></table></td></tr></tbody></table><table align='center' border='0' cellpadding='0' cellspacing='0' class='row row-10' role='presentation' style='mso-table-lspace:0;mso-table-rspace:0;background-color:#fff' width='100%'><tbody><tr><td><table align='center' border='0' cellpadding='0' cellspacing='0' class='row-content stack' role='presentation' style='mso-table-lspace:0;mso-table-rspace:0;color:#000;width:640px' width='640'><tbody><tr><td class='column column-1' style='mso-table-lspace:0;mso-table-rspace:0;font-weight:400;text-align:left;vertical-align:top;padding-top:0;padding-bottom:0;border-top:0;border-right:0;border-bottom:0;border-left:0' width='100%'><div class='spacer_block' style='height:30px;line-height:30px;font-size:1px'> </div></td></tr></tbody></table></td></tr></tbody></table><table align='center' border='0' cellpadding='0' cellspacing='0' class='row row-11' role='presentation' style='mso-table-lspace:0;mso-table-rspace:0;background-color:#fff' width='100%'><tbody><tr><td><table align='center' border='0' cellpadding='0' cellspacing='0' class='row-content stack' role='presentation' style='mso-table-lspace:0;mso-table-rspace:0;color:#000;width:640px' width='640'><tbody><tr><td class='column column-1' style='mso-table-lspace:0;mso-table-rspace:0;font-weight:400;text-align:left;vertical-align:top;padding-top:0;padding-bottom:0;border-top:0;border-right:0;border-bottom:0;border-left:0' width='100%'><div class='spacer_block' style='height:30px;line-height:30px;font-size:1px'> </div></td></tr></tbody></table></td></tr></tbody></table>
                   
                     
                </td>
            </tr>
        </tbody>
    </table><!-- End -->
</body>
</html>
";
}