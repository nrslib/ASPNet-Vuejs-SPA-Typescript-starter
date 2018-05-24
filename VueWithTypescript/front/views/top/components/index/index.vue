<template>
    <div>
        <h2>Vue.js SPA with typescript starter</h2>
        <router-link to="/sample" class="btn btn-primary btn-lg">Try a demo</router-link>
    </div>
</template>

<script lang="ts">
    import { Vue, Component } from "vue-property-decorator";

    @Component
    export default class IndexComponent extends Vue{
    }
</script>