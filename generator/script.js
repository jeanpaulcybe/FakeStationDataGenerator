// JSON
function jenerate(objType, objName, valType, value) { // genera una stringa json a partire dai parametri prescelti
    return JSON.stringify({
        "objType": objType,
        "objName": objName,
        "valType": valType,
        "value": value
    });
}

function jenerate(objType, objName, valArray) { // genera una stringa json a partire dai parametri prescelti
    return JSON.stringify({
        "objType": objType,
        "objName": objName,
        "valArray": valArray,
    });
}

function translate(json) {
    return JSON.parse();
}

// STRUMENTI
function isok(value) {
    return !(value === null || value === undefined);
}

function ok(value, alternative = null) {
    return (value === null || value === undefined) ? alternative : value;
}

function remap(value, low1, high1, low2, high2) {
    return low2 + (high2 - low2) * (value - low1) / (high1 - low1);
}
// PERLIN
function rowPerlin(index, dimension = 100, set = 0) {
    let xy = perlin.index_vect(index % dimension, dimension, ok(set, 0));
    return perlin.get(xy.x, xy.y);
}

function mappedPerlin(index, dimension = 100, set = 0, min = 0, max = 100) {
    let xy = perlin.index_vect(index % dimension, dimension, ok(set, 0));
    return remap(perlin.get(xy.x, xy.y), -1, 1, min, max);
}