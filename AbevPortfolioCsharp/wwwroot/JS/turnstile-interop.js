//window.cfTurnstile = {
//    renderWidget: function (el, sitekey, dotNetObjRef) {
//        window.turnstile.render(el, {
//            sitekey,
//            callback: function (token) {
//                window.cfTurnstile._token = token;
//                if (dotNetObjRef) {
//                    dotNetObjRef.invokeMethodAsync('OnTurnstileReady');
//                }
//            }
//        });
//    },
//    getToken: function () {
//        return window.cfTurnstile._token || "";
//    },
//    reset: function () {
//        window.turnstile.reset();
//        window.cfTurnstile._token = "";
//    }
//};

// wwwroot/JS/turnstile-interop.js - newcd
window.cfTurnstile = {
    renderWidget: (element, siteKey, dotNetObjRef) =>
        window.turnstile.render(element, {
            sitekey: siteKey,
            theme: 'dark',
            callback: () => {
                console.log('Turnstile ready');
                dotNetObjRef.invokeMethodAsync('OnTurnstileReady');
            }
        }),

    getToken: () =>
        document.querySelector('input[name="cf-turnstile-response"]')?.value || '',

    reset: () => window.turnstile?.reset?.()
};
