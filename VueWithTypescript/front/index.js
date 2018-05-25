import Vue from 'vue';
import VueRouter from 'vue-router';
import Route from './routes';
Vue.use(VueRouter);
var router = new VueRouter({
    mode: 'history',
    routes: Route
});
var app = new Vue({
    el: '#app',
    router: router
});
