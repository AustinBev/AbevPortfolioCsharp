window.cfTurnstile = {
    renderWidget: function (el, sitekey, dotNetObjRef) {
        window.turnstile.render(el, {
            sitekey,
            callback: function (token) {
                window.cfTurnstile._token = token;
                if (dotNetObjRef) {
                    dotNetObjRef.invokeMethodAsync('OnTurnstileReady');
                }
            }
        });
    },
    getToken: function () {
        return window.cfTurnstile._token || "";
    },
    reset: function () {
        window.turnstile.reset();
        window.cfTurnstile._token = "";
    }
};
