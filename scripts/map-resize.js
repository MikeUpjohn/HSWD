/**
* Adapted from http://social.msdn.microsoft.com/Forums/en-US/vemapcontroldev/thread/df990275-4e94-4575-996a-e6b593aa99ec
**/

var map = null;

function resize() {
    var width = document.documentElement.clientWidth;
    var height = document.documentElement.clientHeight;

    document.getElementById('map').style.width = width + 'px';
    document.getElementById('map').style.height = height + 'px';

    if (map != null) {
        map.Resize(w, h);
    }
};

function load() {
    map = new VEMap('map');
    map.LoadMap();
}

window.onresize = resize;