// npm init komutuyla proje oluşturulur.

/*
`node index.js` veya `node index` komutu ile çalıştırabilir.

`scripts` altına `“start”:  “node index.js”` eklenirse `npm start` ile de çağrılabilir.

normalde `npm run start` yazman gerekir fakat start’a özel run kullanmadan kısayol mevcut.

`npm run scriptname` ile tüm scriptleri çalıştırabilirsin.

bir script’e && ile birden fazla komut ekleyebilirsin:

"scripts": {
		"start": "node index.js",
		"dev": "node index.js && port=3001"
}

`npm run dev` çalıştığında index.js çalıştılır ve uygulama 3001 portunda ayağa kalkar.
*/

/*
`npm install modulename` veya `npm i modulename` ile modül eklenebilir.
https://www.npmjs.com/package/package

eklenen modüller dependencies altında görünür.

modül dosyası silinirse `npm install` yazarsan hepsi tekrar yüklenir.

sadece geliştirme ortamında kullanılacak bir paketi yüklerken —save-dev komutunu eklersen 
	npm install nodemon --save-dev 
o paketi devDependencies altına yükler ve canlıda gereksiz yere yer işgal etmez.

"devDependencies": {
    "nodemon": "^3.0.2"
}
*/