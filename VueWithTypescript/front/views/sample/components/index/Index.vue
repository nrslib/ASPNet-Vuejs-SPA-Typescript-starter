<template>
    <div>
        <h2>This is Index</h2>
        <p><router-link :to="{name: 'next'}" class="btn btn-primary btn-lg">Next</router-link></p>
    </div>
</template>

<script lang="ts">
    import {Vue, Component} from "vue-property-decorator";

    // Hook before route enter
    Component.registerHooks([
        'beforeRouteEnter',
    ]);

    @Component
    export default class IndexComponent extends Vue{
    }
</script>