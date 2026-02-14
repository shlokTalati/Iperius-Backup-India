var app = new Vue({
    el: '#app',
   
    data: {
        US_conversion: "1.12", //fisso
        selected: 2,
        console: [
            { id: '20', console: '20 PC/Server', price: '₹ '+(39*88), link: '' },
            { id: '50', console: '50 PC/Server', price: '₹ '+(89*88), link: '' },
            { id: '100', console: '100 PC/Server', price: '₹ '+(177*88), link: '' },
            { id: '150', console: '150 PC/Server', price: '₹ '+(264*88), link: '' },
            { id: '200', console: '200 PC/Server', price: '₹ '+(349*88), link: '' },
            { id: '350', console: '350 PC/Server', price: '₹ '+(589*88), link: '' },
            { id: '500', console: '500 PC/Server', price: '₹ '+(789*88), link:'' },
            { id: '750', console: '750 PC/Server', price: '₹ '+(999*88), link: '' }
        ],
        storage: [
            { id: '50', storage: '50 GB', price: '₹ '+(39*88), link: '' },
            { id: '100', storage: '100 GB', price: '₹ '+(69*88), link: ''},
            { id: '200', storage: '200 GB', price: '₹ '+(139*88), link: '' },
            { id: '300', storage: '300 GB', price: '₹ '+(199*88), link: '' },
            { id: '500', storage: '500 GB', price: '₹ '+(339*88), link: '' },
            { id: '1T', storage: '1 TB', price: '₹ '+(559*88), link: '' },
            { id: '2T', storage: '2 TB', price: '₹ '+(1099*88), link: '' },
            { id: '3T', storage: '3 TB', price: '₹ '+(1499*88), link:'' }

        ],
        backup: [
            { id: '15', version: 'Desktop 1 PC', price: '₹ '+(29*110), link: '', more: '/iperius-backup-desktop.aspx'},
            { id: '3000', version: 'Desktop 3 PC', price: '₹ '+(59*110), link: '', more: '/iperius-backup-desktop.aspx' },
            { id: '20', version: 'Essential', price: '₹ '+(69*110), link: '', more: '/backup-software-windows.aspx#compare' },
            { id: '50', version: 'Advanced Database', price: '₹ '+(199*110), link: '', more: '/backup-database.aspx' },
            { id: '70', version: 'Advanced Exchange', price: '₹ '+(199*110), link: '', more: '/backup-exchange-software-export-mailboxes-pst.aspx' },
            { id: '30', version: 'Advanced Tape', price: '₹ '+(199*110), link: '', more: '/tape-backup-software.aspx' },
            { id: '60', version: 'Advanced VM', price: '₹ '+(219*110), link: '', more: '/software-backup-esxi-hyper-v.aspx' },
            { id: '80', version: 'Full', price: '₹ '+(299*110), link: '', more: '/backup-windows-server.aspx' }

        ],
        remote: [
            { id: '5000', dispositivi: 'unlimited', sessions: '2', version: 'Small', price_month: '₹ '+(855), price: '₹ '+(99*88), link: '', more: '' },
            { id: '5100', dispositivi: 'unlimited', sessions: '5', version: 'Medium', price_month: '₹ '+(2038), price: '₹ '+(239*88), link: '', more: '' },
	    { id: '5300', dispositivi: 'unlimited', sessions: '15', version: 'Pro 15', price_month: '₹ '+(5098), price: '₹ '+(589*88), link: '', more: '' }           
/* { id: '5200', dispositivi: 'unlimited', sessions: '10', version: 'Pro 10', price_month: '₹ '+(3399*88), price: '₹ '+(399*88), link: '', more: '' },
            { id: '5300', dispositivi: 'unlimited', sessions: '20', version: 'Pro 20', price_month: '₹ '+(6419*88), price: '₹ '+(769*88), link: '', more: '' },
            { id: '5400', dispositivi: 'unlimited', sessions: '30', version: 'Pro 30', price_month: '₹ '+(9429*88), price: '₹ '+(1129*88), link: '', more: '' },
            { id: '9000', dispositivi: 'unlimited', sessions: '50', version: 'Pro 50', price_month: '₹ '+(15429*88), price: '₹ '+(1849*88), link: '', more: '' },
            { id: '9050', dispositivi: 'unlimited', sessions: '75', version: 'Pro 75', price_month: '₹ '+(22759*88), price: '₹ '+(2724*88), link: '', more: '' },
            { id: '9000', dispositivi: 'unlimited', sessions: '100', version: 'Pro 100', price_month: '₹ '+(29999*88), price: '₹ '+(3599*88), link: '', more: '' },
            { id: '9100', dispositivi: 'unlimited', sessions: '150', version: 'Pro 150', price_month: '₹ '+(44529*88), price: '₹ '+(5339*88), link: '', more: '' },
            { id: '9200', dispositivi: 'unlimited', sessions: '200', version: 'Pro 200', price_month: '₹ '+(58399*88), price: '₹ '+(6999*88), link: '', more: '' }
*/

        ],
        backup_advanced: [
            { id: '60', version: 'Vmware', price: '₹ '+(26477), link: '', more: '' },
            { id: '50', version: 'Sql', price: '₹ '+(19900), link: '', more: '' },
            { id: '30', version: 'Exchange', price: '₹ '+(24059), link: '', more: '' },
            { id: '70', version: 'Tape', price: '₹ '+(36149), link: '', more: '' }
        ],
        backup_desktop: [
            { id: '15', version: 'Desktop 1 PC', price: '₹ '+(3506), link: '', more: '/iperius-backup-desktop.aspx' },
            { id: '3000', version: 'Desktop 3 PC', price: '₹ '+(7133), link: '', more: '/iperius-backup-desktop.aspx' }
        ],
        selectedItem: { id: '5300', dispositivi: 'unlimited', sessions: '15', version: 'Pro 15', price_month: '₹ '+(5098), price: '₹ '+(589*88), link: '', more: '' },
        console_selected: 1,  
        storage_selected: 1, 
        remote_selected: 2,
        backup_advanced_selected: 1,
        backup_desktop_selected: 2,
    },
    beforeMount: function () {
        this.getUSconversion();
    },
    methods: {
        

        changeQuantity: function (sCampo, sSegno) {
           
            var objCampo = document.getElementById(sCampo);
            var iValoreCampo=0;
            if (isNaN(objCampo.value)) { iValoreCampo = 0; }
            else { iValoreCampo = (objCampo.value / 1); }
            if (sSegno == '+') { iValoreCampo = iValoreCampo + 1; }
            else if (sSegno == '-') { iValoreCampo = iValoreCampo - 1; }
            if (iValoreCampo < 1) { iValoreCampo = 1; }
            objCampo.value = iValoreCampo.toString();
        },

        getUSconversion: function () {
            //axios.get("https://free.currencyconverterapi.com/api/v6/convert?q=EUR_USD&compact=y&apiKey=76beaebfc50e5cc0ff7d")
            //    .then(response => { this.US_conversion = response.data.EUR_USD.val });
        },

        getUSprice: function (price) {
            return (this.US_conversion * price.split(" ")[1]).toFixed(1);
        }
        
    }
	    

})




