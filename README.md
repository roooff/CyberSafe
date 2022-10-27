# Hackathon-4-10-22
``https://www.taccgl.org/blog/HTMLpages-with-3D-objects.html``
``
var loadedModel = taccgl.objFile().read( '/objtest/roundcube/roundcube1.obj');
taccgl.actor("examplediv", loadedModel.scene()) . rotateMiddle(1,1,1) . duration(10) .start();``
