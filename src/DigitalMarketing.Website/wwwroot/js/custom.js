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

function SetColors(colorVariables) {

    colorVariables.forEach((colorVariable) => {
        document.documentElement.style.setProperty(colorVariable.name, colorVariable.value)
    });

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

function SetAccordion() {
    $('.accordion li').click(function () {
        if ($(this).closest('.accordion').hasClass('one-open')) {
            $(this).closest('.accordion').find('li').removeClass('active');
            $(this).addClass('active');
        } else {
            $(this).toggleClass('active');
        }
        if (typeof window.mr_parallax !== "undefined") {
            setTimeout(mr_parallax.windowLoad, 500);
        }
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
