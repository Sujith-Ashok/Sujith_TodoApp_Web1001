// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

if ('caches' in window) {
    const cacheName = 'Todo_Offline';
    let taskBtn = $("#OffBtn");
    let createBtn = $("#CreateBtn"); 
    let createOff = $("#createOff");

    let doneBtn = $("#done")

    let checkCache = (url, cacheChange = true) => {
        caches.open(cacheName).then((cache) => {
            cache.match(url).then((response) => {
                let match = ('object' == typeof response);
                if (match) {
                    if (cacheChange)
                        cache.delete(window.location.href);
                        

                    if (cacheChange) {
                        taskBtn.val('Offline Mode');
                        taskBtn.attr('aria-label', 'Offline Mode');

                        createBtn.val('Offline Mode');
                        createBtn.attr('aria-label', 'Offline Mode');
                        document.getElementById('createOff').style.visibility = 'visible'
                        document.getElementById('done').style.visibility = 'visible'

                    } else {
                        taskBtn.val('Offline Mode is On');

                        createBtn.val('Offline Mode is On');

                        document.getElementById('createOff').style.visibility = 'hidden'
                        document.getElementById('done').style.visibility = 'hidden'
 
                    }

                } else {
                    if (cacheChange)
                        cache.add(window.location.href);
                       

                    if (cacheChange) {
                        taskBtn.val('Offline Mode is On');

                        createBtn.val('Offline Mode is On');
                        
                        document.getElementById('createOff').style.visibility = 'hidden'
                        document.getElementById('done').style.visibility = 'hidden'
       
                    } else {
                        taskBtn.val('Offline Mode');
                        taskBtn.attr('aria-label', 'Offline Mode ');

                        createBtn.val('Offline Mode');
                        createBtn.attr('aria-label', 'Offline Mode ');
                        
                        document.getElementById('createOff').style.visibility = 'visible'
                        document.getElementById('done').style.visibility = 'visible'
                        
                    }
                }
            });
        });
    }

    taskBtn.on("click", () => {
        checkCache(window.location.href);
    });

    createBtn.on("click", () => {
        checkCache(window.location.href);
    });

    checkCache(window.location.href, false);

    taskBtn.removeAttr('hidden');
    createBtn.removeAttr('hidden');
}



    
//(async function () {

    document.getElementById('status').innerHTML = navigator.onLine ? 'online' : 'offline';

    var target = document.getElementById('target');

    function handleStateChange() {
        var timeBadge = new Date().toTimeString().split(' ')[0];
        var newState = document.createElement('p');
        var state = navigator.onLine ? 'online' : 'offline';
        let createOff = $("#createOff");
        createOff.removeAttr('hidden');

        newState.innerHTML = '' + timeBadge + ' Connection state changed to ' + state + '.';
        target.appendChild(newState);

       
    }

window.addEventListener('online', (event) => {
    let createOff = $("#createOff");
    let done = $("#done");
    document.getElementById('createOff').style.visibility = 'visible'
    document.getElementById('done').style.visibility = 'visible'
});
window.addEventListener('offline', (event) => {
    let createOff = $("#createOff");
    let done = $("#done");
    document.getElementById('createOff').style.visibility = 'hidden'
    document.getElementById('done').style.visibility = 'hidden'

});

//    //if (navigator.onLine) {
//    // $('#done').removeAttr('hidden')
//    //}

//})()


    //(async function () {
    //    if ('Notification' in window) {
    //        let canAskNotify = false;
    //        let canNotify = false;

    //        if ('permissions' in navigator) {
    //            let permState = await navigator.permissions.query({ name: 'notifications' });
    //            if (permState.state !== 'denied') {
    //                canAskNotify = true;
    //                if (permState.state === 'granted') {
    //                    canNotify = true;
    //                }
    //            }
    //        } else {
    //            if (Notification.permission !== 'denied') {
    //                canAskNotify = true;
    //                if (Notification.permission === 'granted') {
    //                    canNotify = true;
    //                }
    //            }
    //        }

    //        if (canAskNotify && !canNotify) {
    //            $("#yesNotify").on("click", () => { Notification.requestPermission() });
    //            $("#noNotify").on("click", () => { $("#askForNotification").hide() });
    //            $('#sendNotifications').on("click", () => { $("#askForNotification").show() })
    //            $('#sendNotifications').removeAttr('hidden');
    //        }
    //    }
    //})()
