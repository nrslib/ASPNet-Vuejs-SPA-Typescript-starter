import Vue from 'vue';
import VueRouter from 'vue-router';
import { Component } from "vue-property-decorator";
import Route from './routes';

Vue.use(VueRouter);

const router = new VueRouter({
    mode: 'history',
    routes: Route
});

const app = new Vue({
    el: '#app',
    router: router
});