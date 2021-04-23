const TodoCache = 'Sujith To-Do website cache';
//const TodoSecondaryCache = 'Application cache second';

let urlsToCache = [
    '/',
    '/css/site.css',
    '/js/site.js'

];

self.addEventListener('install', function (event) {
    console.info('Service worker Installed');

    event.waitUntil(
        caches.open(TodoCache)
            .then(function (cache) {
                console.log('Opened cache');
                return cache.addAll(urlsToCache);
            })
    );

    console.info('the page is being cached');
});


self.addEventListener('fetch', function (event) {
    event.respondWith(
        caches.match(event.request)
            .then(function (response) {

                if (response) {
                    return response;
                }

                //const newCache = fetch(event.request);
                //caches.open(TodoSecondaryCache).then((cache) => {
                //    cache.add(event.request);
                //});

                //return newCache;

                return fetch(event.request);
            }
            )
    );
});