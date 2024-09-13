
window.addEventListener("scroll",function () {
	var navbar = this.document.querySelector("nav");
	navbar.classList.toggle("fixed" , this.window.scrollY>200);
})

$.fn.jQuerySimpleCounter = function( options ) {
	    var settings = $.extend({
	        start:  0,
	        end:    100,
	        easing: 'swing',
	        duration: 400,
	        complete: ''
	    }, options );

	    var thisElement = $(this);

	    $({count: settings.start}).animate({count: settings.end}, {
			duration: settings.duration,
			easing: settings.easing,
			step: function() {
				var mathCount = Math.ceil(this.count);
				thisElement.text(mathCount);
			},
			complete: settings.complete
		});
	};


$('#number1').jQuerySimpleCounter({end: 500,duration: 5000});
$('#number2').jQuerySimpleCounter({end: 10500,duration: 5000});
$('#number3').jQuerySimpleCounter({end: 5000,duration: 5000});
$('#number4').jQuerySimpleCounter({end: 100,duration: 5000});



  
  