<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TravelExpertsWeb._Default" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="Carousel" runat="server">
 <!-- Author:Sneha Patel(000783907) Date:29-July-2018 Purpose: designing Home Page with slider and texts for Website -->
    <div id="myCarousel" class="carousel slide" data-ride="carousel">        
        <!-- Indicators -->
      <ol class="carousel-indicators">
         <li data-target="#myCarousel" data-slide-to="0" class="active"></li>
         <li data-target="#myCarousel" data-slide-to="1"></li>
         <li data-target="#myCarousel" data-slide-to="2"></li>
         <li data-target="#myCarousel" data-slide-to="3"></li>
      </ol>
	  <!-- Wrapper for slides -->
     <div class="carousel-inner" role="listbox" style="margin-left:0px; margin-right:0px; border:0px;">

         <div class="item active">
                 <img src="Images/img31.jpg" alt="Image"/>
                 <div class="carousel-caption">
                 <h2>Dont let your dreams be dreams</h2>
                 <p> Book with us today! </p>               
                 </div>
         </div>
         <div class="item">
                 <img src="Images/img32.jpg" alt="Image"/>
                 <div class="carousel-caption">
                 <h2>Dont let your dreams be dreams</h2>
                 <p> Book with us today! </p>                
                 </div>
         </div>
		 <div class="item">
                 <img src="Images/img33.jpg" alt="Image"/>
				 <div class="carousel-caption">
                 <h2>Dont let your dreams be dreams</h2>
                 <p> Book with us today! </p>               
			     </div>
		 </div>
		 <div class="item">
                 <img src="Images/img34.jpg" alt="Image"/>
				 <div class="carousel-caption">
                 <h2>Dont let your dreams be dreams</h2>
                 <p> Book with us today! </p>              
			     </div>
		 </div>
	 </div>
     <!-- Controlls for slides -->

         <a class="left carousel-control" href="#myCarousel" role="button" data-slide="prev">
             <span class="glyphicon glyphicon-chevron-left" aria-hidden="true"></span>
             <span class="sr-only">Previous</span>
         </a>
         <a class="right carousel-control" href="#myCarousel" role="button" data-slide="next">
             <span class="glyphicon glyphicon-chevron-right" aria-hidden="true"></span>
             <span class="sr-only">Next</span>
         </a>
     </div>
   
    <div class="row">
        <div class="col-md-4">
            <h2>Your Personal Travel Agent</h2>
            <p>
                Remember how easy it used to be book a holiday? When someone else took care of everything? When they knew you well enough to get it just right? 
                At Travel Experts we believe travel should be personal. That’s why you deserve your own travel expert, who will build something that fits you perfectly.
            </p>          
        </div>
        <div class="col-md-4">
            <h2>Truly Independent</h2>
            <p>
                We’re proud to be family-owned. Our independence makes us unique. It means your Travel Expert’s Agent is able to book with a huge rang of travel providers. 
                That way you can be confident you’re getting a holiday which suits your needs and your budget, and not the holiday which is best for our boardroom.
            </p>           
        </div>
        <div class="col-md-4">
            <h2>We’re Global</h2>
            <p>
                With over 1,500 friendly and professional Travel Experts around the world, were only ever a phone call away. Ant time of the day or night, wherever you are, 
                you can reach us. And our global network means that Travel Experts around the world can share their experience – which means accurate local knowledge behind every single booking.
            </p>
           
        </div>
    </div>

</asp:Content>
