var mr_firstSectionHeight,
    mr_nav,
    mr_fixedAt,
    mr_navOuterHeight,
    mr_navScrolled = false,
    mr_navFixed = false,
    mr_outOfSight = false,
    mr_floatingProjectSections,
    mr_scrollTop = 0;

//reCaptcha

var My;
(function (My) {
    var reCAPTCHA;
    (function (reCAPTCHA) {
        let scriptLoaded = null;
        function waitScriptLoaded(resolve) {
            if (typeof (grecaptcha) !== 'undefined' && typeof (grecaptcha.render) !== 'undefined')
                resolve();
            else
                setTimeout(() => waitScriptLoaded(resolve), 100);
        }
        function init() {
            const scripts = Array.from(document.getElementsByTagName('script'));
            if (!scripts.some(s => (s.src || '').startsWith('https://www.google.com/recaptcha/api.js'))) {
                const script = document.createElement('script');
                script.src = 'https://www.google.com/recaptcha/api.js?render=explicit';
                script.async = true;
                script.defer = true;
                document.head.appendChild(script);
            }
            if (scriptLoaded === null)
                scriptLoaded = new Promise(waitScriptLoaded);
            return scriptLoaded;
        }
        reCAPTCHA.init = init;
        function render(dotNetObj, selector, siteKey) {
            return grecaptcha.render(selector, {
                'sitekey': siteKey,
                'callback': (response) => { dotNetObj.invokeMethodAsync('CallbackOnSuccess', response); },
                'expired-callback': () => { dotNetObj.invokeMethodAsync('CallbackOnExpired'); }
            });
        }
        reCAPTCHA.render = render;
        function getResponse(widgetId) {
            return grecaptcha.getResponse(widgetId);
        }
        reCAPTCHA.getResponse = getResponse;
    })(reCAPTCHA = My.reCAPTCHA || (My.reCAPTCHA = {}));
})(My || (My = {}));
//# sourceMappingURL=script.js.map


function SetNavBar() {

    // Navigation

    if (!$('nav').hasClass('fixed') && !$('nav').hasClass('absolute')) {

        // Make nav container height of nav

        $('.nav-container').css('min-height', $('nav').outerHeight(true));

        $(window).resize(function () {
            $('.nav-container').css('min-height', $('nav').outerHeight(true));
        });

        // Compensate the height of parallax element for inline nav

        if ($(window).width() > 768) {
            $('.parallax:nth-of-type(1) .background-image-holder').css('top', -($('nav').outerHeight(true)));
        }

        // Adjust fullscreen elements

        if ($(window).width() > 768) {
            $('section.fullscreen:nth-of-type(1)').css('height', ($(window).height() - $('nav').outerHeight(true)));
        }

    } else {
        $('body').addClass('nav-is-overlay');
    }

    if ($('nav').hasClass('bg-dark')) {
        $('.nav-container').addClass('bg-dark');
    }


    // Fix nav to top while scrolling

    mr_nav = $('body .nav-container nav:first');
    mr_navOuterHeight = $('body .nav-container nav:first').outerHeight();
    mr_fixedAt = typeof mr_nav.attr('data-fixed-at') !== typeof undefined ? parseInt(mr_nav.attr('data-fixed-at').replace('px', '')) : parseInt($('section:nth-of-type(1)').outerHeight());
    window.addEventListener("scroll", updateNav, false);

    // Menu dropdown positioning

    $('.menu > li > ul').each(function () {
        var menu = $(this).offset();
        var farRight = menu.left + $(this).outerWidth(true);
        if (farRight > $(window).width() && !$(this).hasClass('mega-menu')) {
            $(this).addClass('make-right');
        } else if (farRight > $(window).width() && $(this).hasClass('mega-menu')) {
            var isOnScreen = $(window).width() - menu.left;
            var difference = $(this).outerWidth(true) - isOnScreen;
            $(this).css('margin-left', -(difference));
        }
    });

    // Mobile Menu

    $('.mobile-toggle').click(function () {
        $('.nav-bar').toggleClass('nav-open');
        $(this).toggleClass('active');
    });

    $('.menu li').click(function (e) {
        if (!e) e = window.event;
        e.stopPropagation();
        if ($(this).find('ul').length) {
            $(this).toggleClass('toggle-sub');
        } else {
            $(this).parents('.toggle-sub').removeClass('toggle-sub');
        }
    });

    $('.menu li a').click(function () {
        if ($(this).hasClass('inner-link')) {
            $(this).closest('.nav-bar').removeClass('nav-open');
        }
    });

    $('.module.widget-handle').click(function () {
        $(this).toggleClass('toggle-widget-handle');
    });

    $('.search-widget-handle .search-form input').click(function (e) {
        if (!e) e = window.event;
        e.stopPropagation();
    });

    // Offscreen Nav

    if ($('.offscreen-toggle').length) {
        $('body').addClass('has-offscreen-nav');
    }
    else {
        $('body').removeClass('has-offscreen-nav');
    }

    $('.offscreen-toggle').click(function () {
        $('.main-container').toggleClass('reveal-nav');
        $('nav').toggleClass('reveal-nav');
        $('.offscreen-container').toggleClass('reveal-nav');
    });

    $('.main-container').click(function () {
        if ($(this).hasClass('reveal-nav')) {
            $(this).removeClass('reveal-nav');
            $('.offscreen-container').removeClass('reveal-nav');
            $('nav').removeClass('reveal-nav');
        }
    });

    $('.offscreen-container a').click(function () {
        $('.offscreen-container').removeClass('reveal-nav');
        $('.main-container').removeClass('reveal-nav');
        $('nav').removeClass('reveal-nav');
    });


}


function updateNav() {

    var scrollY = mr_scrollTop;

    if (scrollY <= 0) {
        if (mr_navFixed) {
            mr_navFixed = false;
            mr_nav.removeClass('fixed');
        }
        if (mr_outOfSight) {
            mr_outOfSight = false;
            mr_nav.removeClass('outOfSight');
        }
        if (mr_navScrolled) {
            mr_navScrolled = false;
            mr_nav.removeClass('scrolled');
        }
        return;
    }

    if (scrollY > mr_navOuterHeight + mr_fixedAt) {
        if (!mr_navScrolled) {
            mr_nav.addClass('scrolled');
            mr_navScrolled = true;
            return;
        }
    } else {
        if (scrollY > mr_navOuterHeight) {
            if (!mr_navFixed) {
                mr_nav.addClass('fixed');
                mr_navFixed = true;
            }

            if (scrollY > mr_navOuterHeight + 10) {
                if (!mr_outOfSight) {
                    mr_nav.addClass('outOfSight');
                    mr_outOfSight = true;
                }
            } else {
                if (mr_outOfSight) {
                    mr_outOfSight = false;
                    mr_nav.removeClass('outOfSight');
                }
            }
        } else {
            if (mr_navFixed) {
                mr_navFixed = false;
                mr_nav.removeClass('fixed');
            }
            if (mr_outOfSight) {
                mr_outOfSight = false;
                mr_nav.removeClass('outOfSight');
            }
        }

        if (mr_navScrolled) {
            mr_navScrolled = false;
            mr_nav.removeClass('scrolled');
        }

    }
}

// Countdown Timers

function SetCountdown()
{

    if ($('.countdown').length) {
        $('.countdown').each(function () {
            var date = $(this).attr('data-date');
            $(this).countdown(date, function (event) {
                $(this).text(
                    event.strftime('%D days %H:%M:%S')
                );
            });
        });
    }

}

function SetGallery()
{

    $('.lightbox-grid li a').each(function () {
        var galleryTitle = $(this).closest('.lightbox-grid').attr('data-gallery-title');
        $(this).attr('data-lightbox', galleryTitle);
    });

    $('.background-image-holder').each(function () {
        var imgSrc = $(this).children('img').attr('src');
        $(this).css('background', 'url("' + imgSrc + '")');
        $(this).children('img').hide();
        $(this).css('background-position', 'initial');
    });

    setTimeout(function () {
        $('.background-image-holder').each(function () {
            $(this).addClass('fadeIn');
        });
    }, 200);

}


function SetCarrousel() {

    if ($('.slider-all-controls, .slider-paging-controls, .slider-arrow-controls, .slider-thumb-controls, .logo-carousel').length) {
        $('.slider-all-controls').flexslider({
            start: function (slider) {
                if (slider.find('.slides li:first-child').find('.fs-vid-background video').length) {
                    slider.find('.slides li:first-child').find('.fs-vid-background video').get(0).play();
                }
            },
            after: function (slider) {
                if (slider.find('.fs-vid-background video').length) {
                    if (slider.find('li:not(.flex-active-slide)').find('.fs-vid-background video').length) {
                        slider.find('li:not(.flex-active-slide)').find('.fs-vid-background video').get(0).pause();
                    }
                    if (slider.find('.flex-active-slide').find('.fs-vid-background video').length) {
                        slider.find('.flex-active-slide').find('.fs-vid-background video').get(0).play();
                    }
                }
            }
        });
        $('.slider-paging-controls').flexslider({
            animation: "slide",
            directionNav: false
        });
        $('.slider-arrow-controls').flexslider({
            controlNav: false
        });
        $('.slider-thumb-controls .slides li').each(function () {
            var imgSrc = $(this).find('img').attr('src');
            $(this).attr('data-thumb', imgSrc);
        });
        $('.slider-thumb-controls').flexslider({
            animation: "slide",
            controlNav: "thumbnails",
            directionNav: true
        });
        $('.logo-carousel').flexslider({
            minItems: 1,
            maxItems: 4,
            move: 1,
            itemWidth: 200,
            itemMargin: 0,
            animation: "slide",
            slideshow: true,
            slideshowSpeed: 3000,
            directionNav: false,
            controlNav: false
        });
    }

}


function SetTabs() {

    // Tabbed Content

    $('.tabbed-content').each(function () {
        $(this).append('<ul class="content"></ul>');
    });

    $('.tabs li').each(function () {
        var originalTab = $(this),
            activeClass = "";
        if (originalTab.is('.tabs>li:first-child')) {
            activeClass = ' class="active"';
        }
        var tabContent = originalTab.find('.tab-content').detach().wrap('<li' + activeClass + '></li>').parent();
        originalTab.closest('.tabbed-content').find('.content').append(tabContent);
    });

    $('.tabs li').click(function () {
        $(this).closest('.tabs').find('li').removeClass('active');
        $(this).addClass('active');
        var liIndex = $(this).index() + 1;
        $(this).closest('.tabbed-content').find('.content>li').removeClass('active');
        $(this).closest('.tabbed-content').find('.content>li:nth-of-type(' + liIndex + ')').addClass('active');
    });

}


//Modal
function blazorInitializeModal(dialog, reference) {
    dialog.addEventListener("close", async e => {
        await reference.invokeMethodAsync("OnClose", dialog.returnValue);
    });
}

function blazorOpenModal(dialog) {
    if (!dialog.open) {
        dialog.showModal();
    }
}

function blazorCloseModal(dialog) {
    if (dialog.open) {
        dialog.close();
    }
}

//function SetPlayButton() {

//    // Compensate the height of parallax element for inline nav

//    if ($(window).width() > 768) {
//        $('.parallax:nth-of-type(1) .background-image-holder').css('top', -($('nav').outerHeight(true)));
//    }

//    // Prepare embedded video modals

//    $('iframe[data-provider]').each(function () {
//        var provider = jQuery(this).attr('data-provider');
//        var videoID = jQuery(this).attr('data-video-id');
//        var autoplay = jQuery(this).attr('data-autoplay');
//        var vidURL = '';

//        if (provider == 'vimeo') {
//            vidURL = "http://player.vimeo.com/video/" + videoID + "?badge=0&title=0&byline=0&title=0&autoplay=" + autoplay;
//            $(this).attr('data-src', vidURL);
//        } else if (provider == 'youtube') {
//            vidURL = "https://www.youtube.com/embed/" + videoID + "?showinfo=0&autoplay=" + autoplay;
//            $(this).attr('data-src', vidURL);
//        } else {
//            console.log('Only Vimeo and Youtube videos are supported at this time');
//        }
//    });

//    // Multipurpose Modals

//    jQuery('.foundry_modal[modal-link]').remove();

//    if ($('.foundry_modal').length && (!jQuery('.modal-screen').length)) {
//        // Add a div.modal-screen if there isn't already one there.
//        var modalScreen = jQuery('<div />').addClass('modal-screen').appendTo('body');

//    }

//    jQuery('.foundry_modal').click(function () {
//        jQuery(this).addClass('modal-acknowledged');
//    });

//    jQuery(document).on('wheel mousewheel scroll', '.foundry_modal, .modal-screen', function (evt) {
//        $(this).get(0).scrollTop += (evt.originalEvent.deltaY);
//        return false;
//    });

//    $('.modal-container:not([modal-link])').each(function (index) {
//        if (jQuery(this).find('iframe[src]').length) {
//            jQuery(this).find('.foundry_modal').addClass('iframe-modal');
//            var iframe = jQuery(this).find('iframe');
//            iframe.attr('data-src', iframe.attr('src'));
//            iframe.attr('src', '');

//        }
//        jQuery(this).find('.btn-modal').attr('modal-link', index);

//        // Only clone and append to body if there isn't already one there
//        if (!jQuery('.foundry_modal[modal-link="' + index + '"]').length) {
//            jQuery(this).find('.foundry_modal').clone().appendTo('body').attr('modal-link', index).prepend(jQuery('<i class="ti-close close-modal">'));
//        }
//    });

//    $('.btn-modal').unbind('click').click(function () {
//        var linkedModal = jQuery('.foundry_modal[modal-link="' + jQuery(this).attr('modal-link') + '"]'),
//            autoplayMsg = "";
//        jQuery('.modal-screen').toggleClass('reveal-modal');
//        if (linkedModal.find('iframe').length) {
//            if (linkedModal.find('iframe').attr('data-autoplay') === '1') {
//                var autoplayMsg = '&autoplay=1'
//            }
//            linkedModal.find('iframe').attr('src', (linkedModal.find('iframe').attr('data-src') + autoplayMsg));
//        }
//        if (linkedModal.find('video').length) {
//            linkedModal.find('video').get(0).play();
//        }
//        linkedModal.toggleClass('reveal-modal');
//        return false;
//    });
    
//}