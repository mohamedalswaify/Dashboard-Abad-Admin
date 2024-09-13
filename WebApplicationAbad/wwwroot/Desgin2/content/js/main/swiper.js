    var swiper = new Swiper(".mySwiper", {
      effect: "coverflow",
      grabCursor: true,
      centeredSlides: true,
      slidesPerView: "auto",
      coverflowEffect: {
        rotate: 0,
        stretch: 0,
        depth: 400,
        modifier: 1,
        slideShadows: true,
      },
      autoplay: {
        delay: 1500,
        disableOnInteraction: false,
      },
      pagination: {
        el: ".swiper-pagination",
        clickable: true,
      },

    });


    var swiper = new Swiper(".mySwiper2", {
      effect: "coverflow",
      grabCursor: true,
      centeredSlides: false,
      slidesPerView: "auto",
      coverflowEffect: {
        rotate: 0,
        stretch: 0,
        depth: 400,
        modifier: 1,
        slideShadows: false,
      },

      autoplay: {
        delay: 1500,
        disableOnInteraction: false,
      },

      navigation: {
        prevEl: " .arrow-left",
        nextEl: " .arrow-right",
      }
    });


    var swiper = new Swiper(".mySwiper3", {
      effect: "coverflow",
      grabCursor: true,
      centeredSlides: false,
      slidesPerView: "auto",
      coverflowEffect: {
        rotate: 0,
        stretch: 0,
        depth: 400,
        modifier: 1,
        slideShadows: false,
      },

      autoplay: {
        delay: 1500,
        disableOnInteraction: false,
      },

      navigation: {
        prevEl: ".arrow-left",
        nextEl: ".arrow-right",
      }
    });
