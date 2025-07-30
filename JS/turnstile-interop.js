window.cfTurnstile = (function () {
    let token = null;
    return {
        onSuccess: function (t) { token = t; },
        getToken: function () { return token; },
        reset: function () { if (window.turnstile) window.turnstile.reset(); }
    };
})();
