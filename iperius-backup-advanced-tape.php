
<!doctype html>
<meta name="viewport" content="width=device-width, initial-scale=1">
<html id="ctl00_html_tag" xmlns="http://www.w3.org/1999/xhtml" lang="en">
<head><title>
	Iperius Tape - Backup software for tape drive Server 2008/2012
</title><link rel="shortcut icon" href="/favicon.ico" /><link rel="icon" href="/favicon.ico" type="image/x-icon" />
   <link rel="canonical" href="http://www.iperiusbackup.in/iperius-backup-advanced-tape.php" />
    <!-- Google icon -->
    <link href="https://fonts.googleapis.com/icon?family=Material+Icons" rel="stylesheet" /><link href="https://fonts.googleapis.com/css?family=Montserrat" rel="stylesheet" /><link href="/css/font-awesome.min.css" rel="stylesheet" type="text/css" media="all" />

    <!-- common css -->
    <link rel="stylesheet" href="/css/bootstrap.min.css" type="text/css" media="all" /><link rel="stylesheet" href="/css/propeller.min.css" type="text/css" media="all" /><link rel="stylesheet" href="/css/propeller-theme.css" type="text/css" media="all" /><link rel="stylesheet" href="/css/landing-page.css" type="text/css" media="all" />

    <!--css for custom carousel component -->
    <link rel="stylesheet" href="/css/owl.carousel.min.css" type="text/css" media="all" /><link rel="stylesheet" href="/css/theme-detail.css" type="text/css" media="all" />

    <!-- custom css -->
    <link rel="stylesheet" href="/css/iperius.css" type="text/css" media="all" />

    <!-- css for custom animate component -->
    <link rel="stylesheet" href="/css/animate.css" type="text/css" media="all" /><link rel="stylesheet" type="text/css" media="all" href="/css/lightbox.css" />

    <!-- script for jquery library -->
    <script type='text/javascript' src='/js/jquery-1.12.2.min.js'></script>

    <script type='text/javascript' src='/js/bootstrap.min.js'></script>

     <meta http-equiv="Content-Type" content="text/html; charset=UTF-8" /><meta name="description" content="Iperius is an easy-to-use but yet powerful and reliable tape backup software. Compatible with any tape drive (DAT/LTO), and with Server 2008 / Server 2012
" /><link rel="alternate" href="https://www.iperiusbackup.co.uk" hreflang="en-GB" /><link rel="alternate" href="https://www.iperiusbackup.es" hreflang="es" />
	<!-- Google tag (gtag.js) -->
	<?php include 'components/googletag.php'; ?>
	</head>
	<body>
    <?php include 'components/googletag_body.php'; ?>
  
		<!-- Site Wrapper Start -->
		<div class="siteWrapper" itemscope itemtype="http://schema.org/SoftwareApplication">
			<!-- Site Header -->
            

<?php
include 'components/header.php';
?>
    
            
		    <div class="header-title-bar container" style="height:auto;">
                        <div class="col-lg-10 col-md-10 col-sm-10 col-xs-12 breadcrumb" >                             
                            <span style="font-size:10pt;">Iperius Backup Advanced Tape</span>                             
                    </div>
             
            </div> 

            <!--banner-->         
	           
			<!-- Content Header -->
            <!--header-title-bar -->
         
           
			<!-- Content Wrapper -->
			<div class="contentWrapper">
                 
				<div class="center clearfix">
					<!-- Additional clearfix necessary for non floated objects -->
					<div class="clearfix">
					</div>
					<!-- Content Starts - Header template should end here -->
					<!--Left layout column -->
					<div class="container" id="app" > 



                    


 
					</div>
					<!-- Right layout column -->
					<div class="siteColumnRight">
						<div class="column">
                            
                            
                            <br /><br />
                            
                       </div>
					</div>
					<!-- Content Ends - Footer template should start here -->
				</div>
			</div>

        
	
            <?php
            include 'components/footer.php';
            ?>



		</div>
		<!-- Site Wrapper Ends -->
    
        
 
        <script type='text/javascript' src='/js/contact.js'></script>

        <script type='text/javascript' src='/js/propeller.min.js'></script>

        <script type="text/javascript">
	        // Navbar background color add after scroll down
	        $(window).on("scroll load",function() {    
			        var scroll = $(window).scrollTop();
			        if (scroll >= 100) {
				        $(".navbar-transparent").addClass("navaddcolor");
			        } else {
				        $(".navbar-transparent").removeClass("navaddcolor");
			        }
	        });
	        // Navbar active class add on particular section
	            $(document).ready(function(){
			        var headings = $('.get-class');
			        var nav = $('.nav');
			        $(document).scroll(function(){
				        var docScrollTop = $(document).scrollTop();
				        var windowHeight = $(window).height();
				        var foundHeading;
				        var window40  = windowHeight * 0.45;
				        headings.each(function(index, heading){
					        heading = $(heading);
					        if (heading.offset().top -  window40 <= docScrollTop && (!foundHeading || foundHeading.offset().top < heading.offset().top)){
						        $(this).addClass("active")
						        foundHeading = heading;
					        }
				        });
				        nav.find('.active').removeClass('active');
				        if (foundHeading){
						        nav.find('[href="#' + foundHeading.attr('id') + '"]').parent('li').addClass('active'); 
				        }
			        });
		        });
		  
	        // sidebar close on click of particular section
         //   $('.pmd-navbar-sidebar .navbar-nav li > a').on( 'click', function() {
		       // $('.pmd-navbar-sidebar').removeClass('pmd-sidebar-open');
		       // $('.pmd-sidebar-overlay').removeClass('pmd-sidebar-overlay-active');
		       // $('body').removeClass('pmd-body-open');
	        //});
	
	        $(document).ready(function() {
			
		        $(function(){
			        jQuery('img.svg').each(function(){
				        var $img = jQuery(this);
				        var imgID = $img.attr('id');
				        var imgClass = $img.attr('class');
				        var imgURL = $img.attr('src');

				        jQuery.get(imgURL, function(data) {
					        // Get the SVG tag, ignore the rest
					        var $svg = jQuery(data).find('svg');

					        // Add replaced image's ID to the new SVG
					        if(typeof imgID !== 'undefined') {
						        $svg = $svg.attr('id', imgID);
					        }
					        // Add replaced image's classes to the new SVG
					        if(typeof imgClass !== 'undefined') {
						        $svg = $svg.attr('class', imgClass+' replaced-svg');
					        }
					        // Remove any invalid XML tags as per http://validator.w3.org
					        $svg = $svg.removeAttr('xmlns:a');
					        // Check if the viewport is set, else we gonna set it if we can.
					        if(!$svg.attr('viewBox') && $svg.attr('height') && $svg.attr('width')) {
						        $svg.attr('viewBox', '0 0 ' + $svg.attr('height') + ' ' + $svg.attr('width'))
					        }
					        // Replace image with new SVG
					        $img.replaceWith($svg);

				        }, 'xml');

			        });
		        });

		
			
			
	        })

            $(".nav.navbar-nav").append("<span class='nav-active'></span>")

            $(document).ready(function () {

                $('#containerslide').click(function (e) {
                    
                    var hash = e.target.hash;
                    console.log(e.target.hash);
                    if (hash == "") {
                        $('#containerslide').css("left", "0px");
                        e.preventDefault();
                    }
                    if (hash == "#vmware") {
                        $('#containerslide').css("left", "-260px");
                        e.preventDefault();
                    }
                    if (hash == "#sql") {
                        $('#containerslide').css("left", "-520px");
                        e.preventDefault();
                    }
                    if (hash == "#exchange") {
                        $('#containerslide').css("left", "-790px");
                        e.preventDefault();
                    }
                    if (hash == "#tape") {
                        $('#containerslide').css("left", "-1050px");
                        e.preventDefault();
                    }
                });

              
                if (window.location.search.substr(1).split("=")[1] == "nodistraction") {
                   
                    $("#menu-top-menu").addClass("nodistraction");
                    $(".header-title-bar").addClass("nodistraction");
                    $("#ctl00_cph1_pnlButtons").addClass("hidden");
                }

                    //javascript for tabing component 
                    $('.pmd-tabs').pmdTab();

                   

		            $(document).on("scroll load resize", onScroll);
			        $('.nav a[href^="#"]').on('click', function(e) {
				        e.preventDefault();
				        if ($(window).width() < 768){
					        $(".pmd-sidebar-overlay").trigger("click");
				        }
				        $(document).off("scroll");
				        var target = this.hash,
				        menu = target;
                        $target = $(target);
                        if ($target.hasClass("tab-pane")) return;
				        var headerHeight = $(".navbar").height();
				        $('html, body').stop().animate({
					        'scrollTop': $target.offset().top - headerHeight
				        }, 500, function() {
					        $(document).on("scroll", onScroll);
			        });			
		        });
		        $('.nav-active').hide();
	        });	

	        // Navbar active add remove
	        function onScroll(event) {
		        var scrollPos = $(document).scrollTop() + 205;
		        $('.nav > li > a').each(function() {
			        var currLink = $(this);
			        var refElement = $('#' + currLink.attr("rel"));	
			        if (refElement.position() != undefined) {
				        if (refElement.position().top <= scrollPos && refElement.position().top + refElement.height() > scrollPos) {
					        $('.nav li a').removeClass("active");
					        currLink.addClass("active");
					        $('.nav-active').show();
					        var spanTop = $('.active').offset().left - $('.nav').offset().left;
					        var navWidth = $(this).outerWidth();
					        $('.nav .nav-active').css({"left":spanTop,"width":navWidth});
				            } else {
					        currLink.removeClass("active");
				        }
			        }
		        });
	        }
	
         


        </script>


        <div id="ctl00_pnlBottomScripts">
	

        <script src="/js/lightbox.min.js" type="text/javascript"></script>

        <!-- script for vue.js library -->
        <script src="/js/vue.min.js"></script>
        <script src="https://unpkg.com/axios/dist/axios.min.js"></script>
        <script src="/js/app.js"></script>

        
</div>

  
        


	</body>
  
</html>