// wwwroot/JS/turnstile-interop.js
// Runs after Turnstile core (script tag already uses defer)
window.cfTurnstile = {
    /** Render a widget explicitly */
    renderWidget: (element, siteKey) =>
        window.turnstile.render(element, {
            sitekey: siteKey,
            theme: 'dark',
            callback: () => console.log('Turnstile solved')
        }),

    /** Blazor asks for the current token */
    getToken: () =>
        document.querySelector('input[name="cf-turnstile-response"]')?.value || '',

    /** Reset after a successful send */
    reset: () => window.turnstile?.reset?.()
};
